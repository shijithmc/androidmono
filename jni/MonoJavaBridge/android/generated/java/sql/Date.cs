namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Date : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Date()
		{
			InitJNI();
		}
		protected Date(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString24490;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Date._toString24490)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._toString24490)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf24491;
		public static global::java.sql.Date valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Date.staticClass, global::java.sql.Date._valueOf24491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _setTime24492;
		public override void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Date._setTime24492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._setTime24492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Hours
		{
			get
			{
				return getHours();
			}
			set
			{
				setHours(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHours24493;
		public override int getHours() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Date._getHours24493);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._getHours24493);
		}
		public new int Minutes
		{
			get
			{
				return getMinutes();
			}
			set
			{
				setMinutes(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinutes24494;
		public override int getMinutes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Date._getMinutes24494);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._getMinutes24494);
		}
		public new int Seconds
		{
			get
			{
				return getSeconds();
			}
			set
			{
				setSeconds(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSeconds24495;
		public override int getSeconds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Date._getSeconds24495);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._getSeconds24495);
		}
		internal static global::MonoJavaBridge.MethodId _setHours24496;
		public override void setHours(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Date._setHours24496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._setHours24496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinutes24497;
		public override void setMinutes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Date._setMinutes24497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._setMinutes24497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeconds24498;
		public override void setSeconds(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Date._setSeconds24498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._setSeconds24498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Date24499;
		public Date(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Date.staticClass, global::java.sql.Date._Date24499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date24500;
		public Date(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Date.staticClass, global::java.sql.Date._Date24500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Date.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Date"));
			global::java.sql.Date._toString24490 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "toString", "()Ljava/lang/String;");
			global::java.sql.Date._valueOf24491 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Date.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::java.sql.Date._setTime24492 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "setTime", "(J)V");
			global::java.sql.Date._getHours24493 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "getHours", "()I");
			global::java.sql.Date._getMinutes24494 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "getMinutes", "()I");
			global::java.sql.Date._getSeconds24495 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "getSeconds", "()I");
			global::java.sql.Date._setHours24496 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "setHours", "(I)V");
			global::java.sql.Date._setMinutes24497 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "setMinutes", "(I)V");
			global::java.sql.Date._setSeconds24498 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "setSeconds", "(I)V");
			global::java.sql.Date._Date24499 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "<init>", "(III)V");
			global::java.sql.Date._Date24500 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "<init>", "(J)V");
		}
	}
}
