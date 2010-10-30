namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Deflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Deflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize28354;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "finalize", "()V", ref global::java.util.zip.Deflater._finalize28354);
		}
		internal static global::MonoJavaBridge.MethodId _reset28355;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "reset", "()V", ref global::java.util.zip.Deflater._reset28355);
		}
		internal static global::MonoJavaBridge.MethodId _finished28356;
		public virtual bool finished()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Deflater.staticClass, "finished", "()Z", ref global::java.util.zip.Deflater._finished28356);
		}
		internal static global::MonoJavaBridge.MethodId _end28357;
		public virtual void end()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "end", "()V", ref global::java.util.zip.Deflater._end28357);
		}
		public new byte[] Input
		{
			set
			{
				setInput(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInput28358;
		public virtual void setInput(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setInput", "([B)V", ref global::java.util.zip.Deflater._setInput28358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInput28359;
		public virtual void setInput(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setInput", "([BII)V", ref global::java.util.zip.Deflater._setInput28359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesWritten28360;
		public virtual long getBytesWritten()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Deflater.staticClass, "getBytesWritten", "()J", ref global::java.util.zip.Deflater._getBytesWritten28360);
		}
		internal static global::MonoJavaBridge.MethodId _needsInput28361;
		public virtual bool needsInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Deflater.staticClass, "needsInput", "()Z", ref global::java.util.zip.Deflater._needsInput28361);
		}
		public new byte[] Dictionary
		{
			set
			{
				setDictionary(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28362;
		public virtual void setDictionary(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setDictionary", "([B)V", ref global::java.util.zip.Deflater._setDictionary28362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28363;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setDictionary", "([BII)V", ref global::java.util.zip.Deflater._setDictionary28363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdler28364;
		public virtual int getAdler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "getAdler", "()I", ref global::java.util.zip.Deflater._getAdler28364);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalIn28365;
		public virtual int getTotalIn()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "getTotalIn", "()I", ref global::java.util.zip.Deflater._getTotalIn28365);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesRead28366;
		public virtual long getBytesRead()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Deflater.staticClass, "getBytesRead", "()J", ref global::java.util.zip.Deflater._getBytesRead28366);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalOut28367;
		public virtual int getTotalOut()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "getTotalOut", "()I", ref global::java.util.zip.Deflater._getTotalOut28367);
		}
		public new int Level
		{
			set
			{
				setLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLevel28368;
		public virtual void setLevel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setLevel", "(I)V", ref global::java.util.zip.Deflater._setLevel28368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish28369;
		public virtual void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "finish", "()V", ref global::java.util.zip.Deflater._finish28369);
		}
		internal static global::MonoJavaBridge.MethodId _deflate28370;
		public virtual int deflate(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "deflate", "([BII)I", ref global::java.util.zip.Deflater._deflate28370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _deflate28371;
		public virtual int deflate(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "deflate", "([B)I", ref global::java.util.zip.Deflater._deflate28371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Strategy
		{
			set
			{
				setStrategy(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setStrategy28372;
		public virtual void setStrategy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setStrategy", "(I)V", ref global::java.util.zip.Deflater._setStrategy28372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28373;
		public Deflater(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Deflater._Deflater28373.native == global::System.IntPtr.Zero)
				global::java.util.zip.Deflater._Deflater28373 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(IZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28374;
		public Deflater(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Deflater._Deflater28374.native == global::System.IntPtr.Zero)
				global::java.util.zip.Deflater._Deflater28374 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28375;
		public Deflater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Deflater._Deflater28375.native == global::System.IntPtr.Zero)
				global::java.util.zip.Deflater._Deflater28375 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28375);
			Init(@__env, handle);
		}
		public static int DEFLATED
		{
			get
			{
				return 8;
			}
		}
		public static int NO_COMPRESSION
		{
			get
			{
				return 0;
			}
		}
		public static int BEST_SPEED
		{
			get
			{
				return 1;
			}
		}
		public static int BEST_COMPRESSION
		{
			get
			{
				return 9;
			}
		}
		public static int DEFAULT_COMPRESSION
		{
			get
			{
				return -1;
			}
		}
		public static int FILTERED
		{
			get
			{
				return 1;
			}
		}
		public static int HUFFMAN_ONLY
		{
			get
			{
				return 2;
			}
		}
		public static int DEFAULT_STRATEGY
		{
			get
			{
				return 0;
			}
		}
		static Deflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Deflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Deflater"));
		}
		internal static void InitJNI()
		{
		}
	}
}