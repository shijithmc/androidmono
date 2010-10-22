namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.PolicyNode_))]
	public interface PolicyNode  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.security.cert.PolicyNode getParent();
		bool isCritical();
		int getDepth();
		global::java.util.Iterator getChildren();
		global::java.lang.String getValidPolicy();
		global::java.util.Set getPolicyQualifiers();
		global::java.util.Set getExpectedPolicies();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.PolicyNode))]
	public sealed partial class PolicyNode_ : java.lang.Object, PolicyNode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PolicyNode_()
		{
			InitJNI();
		}
		internal PolicyNode_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParent23561;
		 global::java.security.cert.PolicyNode java.security.cert.PolicyNode.getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.PolicyNode>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getParent23561)) as java.security.cert.PolicyNode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.PolicyNode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getParent23561)) as java.security.cert.PolicyNode;
		}
		internal static global::MonoJavaBridge.MethodId _isCritical23562;
		 bool java.security.cert.PolicyNode.isCritical() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._isCritical23562);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._isCritical23562);
		}
		internal static global::MonoJavaBridge.MethodId _getDepth23563;
		 int java.security.cert.PolicyNode.getDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getDepth23563);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getDepth23563);
		}
		internal static global::MonoJavaBridge.MethodId _getChildren23564;
		 global::java.util.Iterator java.security.cert.PolicyNode.getChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getChildren23564)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getChildren23564)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _getValidPolicy23565;
		 global::java.lang.String java.security.cert.PolicyNode.getValidPolicy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getValidPolicy23565)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getValidPolicy23565)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifiers23566;
		 global::java.util.Set java.security.cert.PolicyNode.getPolicyQualifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getPolicyQualifiers23566)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getPolicyQualifiers23566)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExpectedPolicies23567;
		 global::java.util.Set java.security.cert.PolicyNode.getExpectedPolicies() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_._getExpectedPolicies23567)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyNode_.staticClass, global::java.security.cert.PolicyNode_._getExpectedPolicies23567)) as java.util.Set;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PolicyNode_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PolicyNode"));
			global::java.security.cert.PolicyNode_._getParent23561 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getParent", "()Ljava/security/cert/PolicyNode;");
			global::java.security.cert.PolicyNode_._isCritical23562 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "isCritical", "()Z");
			global::java.security.cert.PolicyNode_._getDepth23563 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getDepth", "()I");
			global::java.security.cert.PolicyNode_._getChildren23564 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getChildren", "()Ljava/util/Iterator;");
			global::java.security.cert.PolicyNode_._getValidPolicy23565 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getValidPolicy", "()Ljava/lang/String;");
			global::java.security.cert.PolicyNode_._getPolicyQualifiers23566 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getPolicyQualifiers", "()Ljava/util/Set;");
			global::java.security.cert.PolicyNode_._getExpectedPolicies23567 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyNode_.staticClass, "getExpectedPolicies", "()Ljava/util/Set;");
		}
	}
}
