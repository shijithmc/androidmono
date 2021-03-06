namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateFormat : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateFormat()
		{
			InitJNI();
		}
		protected DateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format7955;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format7955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _format7956;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format7956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _format7957;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format7957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _is24HourFormat7958;
		public static bool is24HourFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._is24HourFormat7958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeFormat7959;
		public static global::java.text.DateFormat getTimeFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getTimeFormat7959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateFormat7960;
		public static global::java.text.DateFormat getDateFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getDateFormat7960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getLongDateFormat7961;
		public static global::java.text.DateFormat getLongDateFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getLongDateFormat7961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getMediumDateFormat7962;
		public static global::java.text.DateFormat getMediumDateFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getMediumDateFormat7962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateFormatOrder7963;
		public static char[] getDateFormatOrder(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getDateFormatOrder7963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateFormat7964;
		public DateFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._DateFormat7964);
			Init(@__env, handle);
		}
		public static char QUOTE
		{
			get
			{
				return '\'';
			}
		}
		public static char AM_PM
		{
			get
			{
				return 'a';
			}
		}
		public static char CAPITAL_AM_PM
		{
			get
			{
				return 'A';
			}
		}
		public static char DATE
		{
			get
			{
				return 'd';
			}
		}
		public static char DAY
		{
			get
			{
				return 'E';
			}
		}
		public static char HOUR
		{
			get
			{
				return 'h';
			}
		}
		public static char HOUR_OF_DAY
		{
			get
			{
				return 'k';
			}
		}
		public static char MINUTE
		{
			get
			{
				return 'm';
			}
		}
		public static char MONTH
		{
			get
			{
				return 'M';
			}
		}
		public static char SECONDS
		{
			get
			{
				return 's';
			}
		}
		public static char TIME_ZONE
		{
			get
			{
				return 'z';
			}
		}
		public static char YEAR
		{
			get
			{
				return 'y';
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.DateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/DateFormat"));
			global::android.text.format.DateFormat._format7955 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Calendar;)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._format7956 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;J)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._format7957 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Date;)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._is24HourFormat7958 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "is24HourFormat", "(Landroid/content/Context;)Z");
			global::android.text.format.DateFormat._getTimeFormat7959 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getTimeFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getDateFormat7960 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getLongDateFormat7961 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getLongDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getMediumDateFormat7962 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getMediumDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getDateFormatOrder7963 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getDateFormatOrder", "(Landroid/content/Context;)[C");
			global::android.text.format.DateFormat._DateFormat7964 = @__env.GetMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "<init>", "()V");
		}
	}
}
