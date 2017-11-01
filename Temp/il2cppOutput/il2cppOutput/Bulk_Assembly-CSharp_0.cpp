#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array3829468939.h"
#include "AssemblyU2DCSharp_U3CModuleU3E3783534214.h"
#include "AssemblyU2DCSharp_ButtonController1741881492.h"
#include "mscorlib_System_Void1841601450.h"
#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "mscorlib_System_String2029220233.h"

// ButtonController
struct ButtonController_t1741881492;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t1158329972;
// System.String
struct String_t;
extern Il2CppCodeGenString* _stringLiteral2328219732;
extern const uint32_t ButtonController_GameStart_m279976799_MetadataUsageId;
extern Il2CppCodeGenString* _stringLiteral1624192333;
extern const uint32_t ButtonController_Result_m3540330470_MetadataUsageId;
extern Il2CppCodeGenString* _stringLiteral2858758002;
extern const uint32_t ButtonController_Home_m947705300_MetadataUsageId;




// System.Void UnityEngine.MonoBehaviour::.ctor()
extern "C"  void MonoBehaviour__ctor_m2464341955 (MonoBehaviour_t1158329972 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.SceneManagement.SceneManager::LoadScene(System.String)
extern "C"  void SceneManager_LoadScene_m1619949821 (Il2CppObject * __this /* static, unused */, String_t* p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void ButtonController::.ctor()
extern "C"  void ButtonController__ctor_m1811141101 (ButtonController_t1741881492 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void ButtonController::GameStart()
extern "C"  void ButtonController_GameStart_m279976799 (ButtonController_t1741881492 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ButtonController_GameStart_m279976799_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		SceneManager_LoadScene_m1619949821(NULL /*static, unused*/, _stringLiteral2328219732, /*hidden argument*/NULL);
		return;
	}
}
// System.Void ButtonController::Result()
extern "C"  void ButtonController_Result_m3540330470 (ButtonController_t1741881492 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ButtonController_Result_m3540330470_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		SceneManager_LoadScene_m1619949821(NULL /*static, unused*/, _stringLiteral1624192333, /*hidden argument*/NULL);
		return;
	}
}
// System.Void ButtonController::Home()
extern "C"  void ButtonController_Home_m947705300 (ButtonController_t1741881492 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ButtonController_Home_m947705300_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		SceneManager_LoadScene_m1619949821(NULL /*static, unused*/, _stringLiteral2858758002, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
