namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectOutputStream : java.io.OutputStream, ObjectOutput, ObjectStreamConstants
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ObjectOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.io.ObjectOutputStream.PutField_))]
		public abstract partial class PutField : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PutField(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _put19244;
			public abstract void put(java.lang.String arg0, bool arg1);
			internal static global::MonoJavaBridge.MethodId _put19245;
			public abstract void put(java.lang.String arg0, byte arg1);
			internal static global::MonoJavaBridge.MethodId _put19246;
			public abstract void put(java.lang.String arg0, char arg1);
			internal static global::MonoJavaBridge.MethodId _put19247;
			public abstract void put(java.lang.String arg0, short arg1);
			internal static global::MonoJavaBridge.MethodId _put19248;
			public abstract void put(java.lang.String arg0, long arg1);
			internal static global::MonoJavaBridge.MethodId _put19249;
			public abstract void put(java.lang.String arg0, float arg1);
			internal static global::MonoJavaBridge.MethodId _put19250;
			public abstract void put(java.lang.String arg0, double arg1);
			internal static global::MonoJavaBridge.MethodId _put19251;
			public abstract void put(java.lang.String arg0, java.lang.Object arg1);
			internal static global::MonoJavaBridge.MethodId _put19252;
			public abstract void put(java.lang.String arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _write19253;
			public abstract void write(java.io.ObjectOutput arg0);
			internal static global::MonoJavaBridge.MethodId _PutField19254;
			public PutField() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.io.ObjectOutputStream.PutField._PutField19254.native == global::System.IntPtr.Zero)
					global::java.io.ObjectOutputStream.PutField._PutField19254 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.PutField.staticClass, global::java.io.ObjectOutputStream.PutField._PutField19254);
				Init(@__env, handle);
			}
			static PutField()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectOutputStream.PutField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream$PutField"));
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectOutputStream.PutField))]
		internal sealed partial class PutField_ : java.io.ObjectOutputStream.PutField
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PutField_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _put19255;
			public override void put(java.lang.String arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;Z)V", ref global::java.io.ObjectOutputStream.PutField_._put19255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19256;
			public override void put(java.lang.String arg0, byte arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;B)V", ref global::java.io.ObjectOutputStream.PutField_._put19256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19257;
			public override void put(java.lang.String arg0, char arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;C)V", ref global::java.io.ObjectOutputStream.PutField_._put19257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19258;
			public override void put(java.lang.String arg0, short arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;S)V", ref global::java.io.ObjectOutputStream.PutField_._put19258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19259;
			public override void put(java.lang.String arg0, long arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;J)V", ref global::java.io.ObjectOutputStream.PutField_._put19259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19260;
			public override void put(java.lang.String arg0, float arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;F)V", ref global::java.io.ObjectOutputStream.PutField_._put19260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19261;
			public override void put(java.lang.String arg0, double arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;D)V", ref global::java.io.ObjectOutputStream.PutField_._put19261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19262;
			public override void put(java.lang.String arg0, java.lang.Object arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.io.ObjectOutputStream.PutField_._put19262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19263;
			public override void put(java.lang.String arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;I)V", ref global::java.io.ObjectOutputStream.PutField_._put19263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _write19264;
			public override void write(java.io.ObjectOutput arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "write", "(Ljava/io/ObjectOutput;)V", ref global::java.io.ObjectOutputStream.PutField_._write19264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static PutField_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectOutputStream.PutField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream$PutField"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _write19265;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "write", "([BII)V", ref global::java.io.ObjectOutputStream._write19265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19266;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "write", "([B)V", ref global::java.io.ObjectOutputStream._write19266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19267;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "write", "(I)V", ref global::java.io.ObjectOutputStream._write19267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeObject19268;
		public virtual void writeObject(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeObject", "(Ljava/lang/Object;)V", ref global::java.io.ObjectOutputStream._writeObject19268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _defaultWriteObject19269;
		public virtual void defaultWriteObject()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "defaultWriteObject", "()V", ref global::java.io.ObjectOutputStream._defaultWriteObject19269);
		}
		internal static global::MonoJavaBridge.MethodId _flush19270;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "flush", "()V", ref global::java.io.ObjectOutputStream._flush19270);
		}
		internal static global::MonoJavaBridge.MethodId _close19271;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "close", "()V", ref global::java.io.ObjectOutputStream._close19271);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt19272;
		public virtual void writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeInt", "(I)V", ref global::java.io.ObjectOutputStream._writeInt19272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFields19273;
		public virtual global::java.io.ObjectOutputStream.PutField putFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectOutputStream.staticClass, "putFields", "()Ljava/io/ObjectOutputStream$PutField;", ref global::java.io.ObjectOutputStream._putFields19273) as java.io.ObjectOutputStream.PutField;
		}
		internal static global::MonoJavaBridge.MethodId _writeFields19274;
		public virtual void writeFields()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeFields", "()V", ref global::java.io.ObjectOutputStream._writeFields19274);
		}
		internal static global::MonoJavaBridge.MethodId _reset19275;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "reset", "()V", ref global::java.io.ObjectOutputStream._reset19275);
		}
		internal static global::MonoJavaBridge.MethodId _writeChar19276;
		public virtual void writeChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeChar", "(I)V", ref global::java.io.ObjectOutputStream._writeChar19276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes19277;
		public virtual void writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeBytes", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutputStream._writeBytes19277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF19278;
		public virtual void writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeUTF", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutputStream._writeUTF19278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong19279;
		public virtual void writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeLong", "(J)V", ref global::java.io.ObjectOutputStream._writeLong19279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte19280;
		public virtual void writeByte(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeByte", "(I)V", ref global::java.io.ObjectOutputStream._writeByte19280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort19281;
		public virtual void writeShort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeShort", "(I)V", ref global::java.io.ObjectOutputStream._writeShort19281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat19282;
		public virtual void writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeFloat", "(F)V", ref global::java.io.ObjectOutputStream._writeFloat19282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble19283;
		public virtual void writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeDouble", "(D)V", ref global::java.io.ObjectOutputStream._writeDouble19283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _useProtocolVersion19284;
		public virtual void useProtocolVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "useProtocolVersion", "(I)V", ref global::java.io.ObjectOutputStream._useProtocolVersion19284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeObjectOverride19285;
		protected virtual void writeObjectOverride(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeObjectOverride", "(Ljava/lang/Object;)V", ref global::java.io.ObjectOutputStream._writeObjectOverride19285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUnshared19286;
		public virtual void writeUnshared(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeUnshared", "(Ljava/lang/Object;)V", ref global::java.io.ObjectOutputStream._writeUnshared19286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _annotateClass19287;
		protected virtual void annotateClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "annotateClass", "(Ljava/lang/Class;)V", ref global::java.io.ObjectOutputStream._annotateClass19287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _annotateProxyClass19288;
		protected virtual void annotateProxyClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "annotateProxyClass", "(Ljava/lang/Class;)V", ref global::java.io.ObjectOutputStream._annotateProxyClass19288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _replaceObject19289;
		protected virtual global::java.lang.Object replaceObject(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectOutputStream.staticClass, "replaceObject", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.io.ObjectOutputStream._replaceObject19289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _enableReplaceObject19290;
		protected virtual bool enableReplaceObject(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectOutputStream.staticClass, "enableReplaceObject", "(Z)Z", ref global::java.io.ObjectOutputStream._enableReplaceObject19290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStreamHeader19291;
		protected virtual void writeStreamHeader()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeStreamHeader", "()V", ref global::java.io.ObjectOutputStream._writeStreamHeader19291);
		}
		internal static global::MonoJavaBridge.MethodId _writeClassDescriptor19292;
		protected virtual void writeClassDescriptor(java.io.ObjectStreamClass arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeClassDescriptor", "(Ljava/io/ObjectStreamClass;)V", ref global::java.io.ObjectOutputStream._writeClassDescriptor19292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drain19293;
		protected virtual void drain()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "drain", "()V", ref global::java.io.ObjectOutputStream._drain19293);
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean19294;
		public virtual void writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeBoolean", "(Z)V", ref global::java.io.ObjectOutputStream._writeBoolean19294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars19295;
		public virtual void writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeChars", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutputStream._writeChars19295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ObjectOutputStream19296;
		public ObjectOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutputStream._ObjectOutputStream19296.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutputStream._ObjectOutputStream19296 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._ObjectOutputStream19296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectOutputStream19297;
		protected ObjectOutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutputStream._ObjectOutputStream19297.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutputStream._ObjectOutputStream19297 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._ObjectOutputStream19297);
			Init(@__env, handle);
		}
		static ObjectOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}