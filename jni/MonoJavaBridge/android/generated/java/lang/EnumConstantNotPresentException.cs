namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EnumConstantNotPresentException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EnumConstantNotPresentException()
		{
			InitJNI();
		}
		protected EnumConstantNotPresentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _enumType20008;
		public virtual global::java.lang.Class enumType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.EnumConstantNotPresentException._enumType20008)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.EnumConstantNotPresentException.staticClass, global::java.lang.EnumConstantNotPresentException._enumType20008)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _constantName20009;
		public virtual global::java.lang.String constantName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.EnumConstantNotPresentException._constantName20009)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.EnumConstantNotPresentException.staticClass, global::java.lang.EnumConstantNotPresentException._constantName20009)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _EnumConstantNotPresentException20010;
		public EnumConstantNotPresentException(java.lang.Class arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.EnumConstantNotPresentException.staticClass, global::java.lang.EnumConstantNotPresentException._EnumConstantNotPresentException20010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.EnumConstantNotPresentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/EnumConstantNotPresentException"));
			global::java.lang.EnumConstantNotPresentException._enumType20008 = @__env.GetMethodIDNoThrow(global::java.lang.EnumConstantNotPresentException.staticClass, "enumType", "()Ljava/lang/Class;");
			global::java.lang.EnumConstantNotPresentException._constantName20009 = @__env.GetMethodIDNoThrow(global::java.lang.EnumConstantNotPresentException.staticClass, "constantName", "()Ljava/lang/String;");
			global::java.lang.EnumConstantNotPresentException._EnumConstantNotPresentException20010 = @__env.GetMethodIDNoThrow(global::java.lang.EnumConstantNotPresentException.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
		}
	}
}
