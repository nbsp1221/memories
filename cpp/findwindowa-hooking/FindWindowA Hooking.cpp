#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>

BYTE g_pOrgByte[5] = {0, };

HWND WINAPI MyFindWindow(LPCTSTR lpClassName, LPCTSTR lpWindowName);
BOOL Hook(LPCTSTR szDllName, LPCTSTR szFuncName, PROC pfnNew, PBYTE pOrgByte);
BOOL UnHook(LPCTSTR szDllName, LPCTSTR szFuncName, PBYTE pOrgByte);

BOOL APIENTRY DllMain(HANDLE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
		{
			AllocConsole();
			SetConsoleTitle("FindWindowA Hooking");
			
			Hook("user32.dll", "FindWindowA", (PROC)MyFindWindow, g_pOrgByte);
			break;
		}
		
	case DLL_PROCESS_DETACH:
		{
			FreeConsole();
			break;
		}
	}

    return TRUE;
}

HWND WINAPI MyFindWindow(LPCTSTR lpClassName, LPCTSTR lpWindowName)
{
	HWND hWnd;
	char MylpWindowName[100];

	MylpWindowName[0] = 90;

	system("cls");

	cprintf("lpClassName ¡æ %s\n", lpClassName);
	cprintf("lpWindowName ¡æ %s\n\n", lpWindowName);
	
	cprintf("lpWindowName : ");
	cgets(MylpWindowName);

	UnHook("user32.dll", "FindWindowA", g_pOrgByte);

	hWnd = FindWindowA(lpClassName, MylpWindowName + 2);

	Hook("user32.dll", "FindWindowA", (PROC)MyFindWindow, g_pOrgByte);

	cprintf("\nHANDLE ¡æ %d", hWnd);

	return hWnd;
}

BOOL Hook(LPCTSTR szDllName, LPCTSTR szFuncName, PROC pfnNew, PBYTE pOrgByte)
{
	FARPROC pfnOrg;
	DWORD dwOldProtect, dwAddress;

	BYTE pBuf[5] = {0xE9, 0, };
	PBYTE pByte;

	pfnOrg = (FARPROC)GetProcAddress(GetModuleHandle(szDllName), szFuncName);
	pByte = (PBYTE)pfnOrg;

	if (pByte[0] == 0xE9) return FALSE;

	VirtualProtect((LPVOID)pfnOrg, 5, PAGE_EXECUTE_READWRITE, &dwOldProtect);
	
	memcpy(pOrgByte, pfnOrg, 5);
	
	dwAddress = (DWORD)pfnNew - (DWORD)pfnOrg - 5;

	memcpy(&pBuf[1], &dwAddress, 4);
	memcpy(pfnOrg, pBuf, 5);

	VirtualProtect((LPVOID)pfnOrg, 5, dwOldProtect, &dwOldProtect);

	return TRUE;
}

BOOL UnHook(LPCTSTR szDllName, LPCTSTR szFuncName, PBYTE pOrgByte)
{
	FARPROC pfnOrg;
	DWORD dwOldProtect;

	pfnOrg = (FARPROC)GetProcAddress(GetModuleHandle(szDllName), szFuncName);

	VirtualProtect((LPVOID)pfnOrg, 5, PAGE_EXECUTE_READWRITE, &dwOldProtect);

	memcpy(pfnOrg, pOrgByte, 5);

	VirtualProtect((LPVOID)pfnOrg, 5, dwOldProtect, &dwOldProtect);

	return TRUE;
}