namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WeakReference : java.lang.@ref.Reference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WeakReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _WeakReference20997;
		public WeakReference(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.@ref.WeakReference._WeakReference20997.native == global::System.IntPtr.Zero)
				global::java.lang.@ref.WeakReference._WeakReference20997 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.WeakReference.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.WeakReference.staticClass, global::java.lang.@ref.WeakReference._WeakReference20997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WeakReference20998;
		public WeakReference(java.lang.Object arg0, java.lang.@ref.ReferenceQueue arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.@ref.WeakReference._WeakReference20998.native == global::System.IntPtr.Zero)
				global::java.lang.@ref.WeakReference._WeakReference20998 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.WeakReference.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.WeakReference.staticClass, global::java.lang.@ref.WeakReference._WeakReference20998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static WeakReference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.WeakReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/WeakReference"));
		}
		internal static void InitJNI()
		{
		}
	}
}