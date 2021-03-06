namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.microedition.khronos.egl.EGLContext_))]
	public abstract partial class EGLContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGLContext()
		{
			InitJNI();
		}
		protected EGLContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGL15821;
		public abstract global::javax.microedition.khronos.opengles.GL getGL();
		internal static global::MonoJavaBridge.MethodId _getEGL15822;
		public static global::javax.microedition.khronos.egl.EGL getEGL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.egl.EGL>(@__env.CallStaticObjectMethod(javax.microedition.khronos.egl.EGLContext.staticClass, global::javax.microedition.khronos.egl.EGLContext._getEGL15822)) as javax.microedition.khronos.egl.EGL;
		}
		internal static global::MonoJavaBridge.MethodId _EGLContext15823;
		public EGLContext()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.microedition.khronos.egl.EGLContext.staticClass, global::javax.microedition.khronos.egl.EGLContext._EGLContext15823);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLContext"));
			global::javax.microedition.khronos.egl.EGLContext._getGL15821 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;");
			global::javax.microedition.khronos.egl.EGLContext._getEGL15822 = @__env.GetStaticMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext.staticClass, "getEGL", "()Ljavax/microedition/khronos/egl/EGL;");
			global::javax.microedition.khronos.egl.EGLContext._EGLContext15823 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGLContext))]
	public sealed partial class EGLContext_ : javax.microedition.khronos.egl.EGLContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGLContext_()
		{
			InitJNI();
		}
		internal EGLContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGL15824;
		public override global::javax.microedition.khronos.opengles.GL getGL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGLContext_._getGL15824)) as javax.microedition.khronos.opengles.GL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGLContext_.staticClass, global::javax.microedition.khronos.egl.EGLContext_._getGL15824)) as javax.microedition.khronos.opengles.GL;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLContext"));
			global::javax.microedition.khronos.egl.EGLContext_._getGL15824 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext_.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;");
		}
	}
}
