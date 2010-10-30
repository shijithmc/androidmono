namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PipedReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19386;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedReader.staticClass, "close", "()V", ref global::java.io.PipedReader._close19386);
		}
		internal static global::MonoJavaBridge.MethodId _read19387;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedReader.staticClass, "read", "()I", ref global::java.io.PipedReader._read19387);
		}
		internal static global::MonoJavaBridge.MethodId _read19388;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PipedReader.staticClass, "read", "([CII)I", ref global::java.io.PipedReader._read19388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _connect19389;
		public virtual void connect(java.io.PipedWriter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PipedReader.staticClass, "connect", "(Ljava/io/PipedWriter;)V", ref global::java.io.PipedReader._connect19389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ready19390;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.PipedReader.staticClass, "ready", "()Z", ref global::java.io.PipedReader._ready19390);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader19391;
		public PipedReader(java.io.PipedWriter arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedReader._PipedReader19391.native == global::System.IntPtr.Zero)
				global::java.io.PipedReader._PipedReader19391 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(Ljava/io/PipedWriter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader19391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader19392;
		public PipedReader(java.io.PipedWriter arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedReader._PipedReader19392.native == global::System.IntPtr.Zero)
				global::java.io.PipedReader._PipedReader19392 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(Ljava/io/PipedWriter;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader19392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader19393;
		public PipedReader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedReader._PipedReader19393.native == global::System.IntPtr.Zero)
				global::java.io.PipedReader._PipedReader19393 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader19393);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedReader19394;
		public PipedReader(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PipedReader._PipedReader19394.native == global::System.IntPtr.Zero)
				global::java.io.PipedReader._PipedReader19394 = @__env.GetMethodIDNoThrow(global::java.io.PipedReader.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedReader.staticClass, global::java.io.PipedReader._PipedReader19394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PipedReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedReader"));
		}
		internal static void InitJNI()
		{
		}
	}
}