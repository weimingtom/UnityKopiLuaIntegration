using System;
using LuaInterface;

public class ToLuaInterface
{
	public static int ToLua_LuaBindingTest_StaticPrintMessage(KopiLua.Lua.lua_State L)
	{
		LuaBindingTest.StaticPrintMessage("StaticPrintMessage");
		return 1;	
	}
}


