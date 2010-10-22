namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RenamingDelegatingContext : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RenamingDelegatingContext()
		{
			InitJNI();
		}
		protected RenamingDelegatingContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _openFileInput12229;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._openFileInput12229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._openFileInput12229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileOutput12230;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._openFileOutput12230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._openFileOutput12230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _deleteFile12231;
		public override bool deleteFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._deleteFile12231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._deleteFile12231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath12232;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._getFileStreamPath12232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._getFileStreamPath12232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _fileList12233;
		public override global::java.lang.String[] fileList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._fileList12233)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._fileList12233)) as java.lang.String[];
		}
		public new global::java.io.File CacheDir
		{
			get
			{
				return getCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheDir12234;
		public override global::java.io.File getCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._getCacheDir12234)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._getCacheDir12234)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase12235;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._openOrCreateDatabase12235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._openOrCreateDatabase12235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _deleteDatabase12236;
		public override bool deleteDatabase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._deleteDatabase12236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._deleteDatabase12236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath12237;
		public override global::java.io.File getDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._getDatabasePath12237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._getDatabasePath12237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _databaseList12238;
		public override global::java.lang.String[] databaseList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._databaseList12238)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._databaseList12238)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _providerWithRenamedContext12239;
		public static global::android.content.ContentProvider providerWithRenamedContext(java.lang.Class arg0, android.content.Context arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._providerWithRenamedContext12239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProvider;
		}
		internal static global::MonoJavaBridge.MethodId _providerWithRenamedContext12240;
		public static global::android.content.ContentProvider providerWithRenamedContext(java.lang.Class arg0, android.content.Context arg1, java.lang.String arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._providerWithRenamedContext12240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.ContentProvider;
		}
		internal static global::MonoJavaBridge.MethodId _makeExistingFilesAndDbsAccessible12241;
		public virtual void makeExistingFilesAndDbsAccessible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._makeExistingFilesAndDbsAccessible12241);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._makeExistingFilesAndDbsAccessible12241);
		}
		public new global::java.lang.String DatabasePrefix
		{
			get
			{
				return getDatabasePrefix();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePrefix12242;
		public virtual global::java.lang.String getDatabasePrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext._getDatabasePrefix12242)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._getDatabasePrefix12242)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _RenamingDelegatingContext12243;
		public RenamingDelegatingContext(android.content.Context arg0, android.content.Context arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._RenamingDelegatingContext12243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RenamingDelegatingContext12244;
		public RenamingDelegatingContext(android.content.Context arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._RenamingDelegatingContext12244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.RenamingDelegatingContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/RenamingDelegatingContext"));
			global::android.test.RenamingDelegatingContext._openFileInput12229 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.test.RenamingDelegatingContext._openFileOutput12230 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.test.RenamingDelegatingContext._deleteFile12231 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.test.RenamingDelegatingContext._getFileStreamPath12232 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.test.RenamingDelegatingContext._fileList12233 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.test.RenamingDelegatingContext._getCacheDir12234 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.test.RenamingDelegatingContext._openOrCreateDatabase12235 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.test.RenamingDelegatingContext._deleteDatabase12236 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.test.RenamingDelegatingContext._getDatabasePath12237 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.test.RenamingDelegatingContext._databaseList12238 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.test.RenamingDelegatingContext._providerWithRenamedContext12239 = @__env.GetStaticMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "providerWithRenamedContext", "(Ljava/lang/Class;Landroid/content/Context;Ljava/lang/String;)Landroid/content/ContentProvider;");
			global::android.test.RenamingDelegatingContext._providerWithRenamedContext12240 = @__env.GetStaticMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "providerWithRenamedContext", "(Ljava/lang/Class;Landroid/content/Context;Ljava/lang/String;Z)Landroid/content/ContentProvider;");
			global::android.test.RenamingDelegatingContext._makeExistingFilesAndDbsAccessible12241 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "makeExistingFilesAndDbsAccessible", "()V");
			global::android.test.RenamingDelegatingContext._getDatabasePrefix12242 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "getDatabasePrefix", "()Ljava/lang/String;");
			global::android.test.RenamingDelegatingContext._RenamingDelegatingContext12243 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/Context;Ljava/lang/String;)V");
			global::android.test.RenamingDelegatingContext._RenamingDelegatingContext12244 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
		}
	}
}
