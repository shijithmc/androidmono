namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContextWrapper : android.content.Context
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContextWrapper()
		{
			InitJNI();
		}
		protected ContextWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader2985;
		public override global::java.lang.ClassLoader getClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getClassLoader2985)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getClassLoader2985)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission2986;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkPermission2986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkPermission2986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources2987;
		public override global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getResources2987)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getResources2987)) as android.content.res.Resources;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName2988;
		public override global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getPackageName2988)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageName2988)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _attachBaseContext2989;
		protected virtual void attachBaseContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._attachBaseContext2989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._attachBaseContext2989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.Context BaseContext
		{
			get
			{
				return getBaseContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseContext2990;
		public virtual global::android.content.Context getBaseContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getBaseContext2990)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getBaseContext2990)) as android.content.Context;
		}
		public new global::android.content.res.AssetManager Assets
		{
			get
			{
				return getAssets();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAssets2991;
		public override global::android.content.res.AssetManager getAssets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.res.AssetManager>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getAssets2991)) as android.content.res.AssetManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.res.AssetManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getAssets2991)) as android.content.res.AssetManager;
		}
		public new global::android.content.pm.PackageManager PackageManager
		{
			get
			{
				return getPackageManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageManager2992;
		public override global::android.content.pm.PackageManager getPackageManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getPackageManager2992)) as android.content.pm.PackageManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageManager2992)) as android.content.pm.PackageManager;
		}
		public new global::android.content.ContentResolver ContentResolver
		{
			get
			{
				return getContentResolver();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentResolver2993;
		public override global::android.content.ContentResolver getContentResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getContentResolver2993)) as android.content.ContentResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getContentResolver2993)) as android.content.ContentResolver;
		}
		public new global::android.os.Looper MainLooper
		{
			get
			{
				return getMainLooper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMainLooper2994;
		public override global::android.os.Looper getMainLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getMainLooper2994)) as android.os.Looper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getMainLooper2994)) as android.os.Looper;
		}
		public new global::android.content.Context ApplicationContext
		{
			get
			{
				return getApplicationContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationContext2995;
		public override global::android.content.Context getApplicationContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getApplicationContext2995)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getApplicationContext2995)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setTheme2996;
		public override void setTheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._setTheme2996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setTheme2996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Resources.Theme Theme
		{
			get
			{
				return getTheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTheme2997;
		public override global::android.content.res.Resources.Theme getTheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.res.Resources.Theme>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getTheme2997)) as android.content.res.Resources.Theme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.res.Resources.Theme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getTheme2997)) as android.content.res.Resources.Theme;
		}
		public new global::android.content.pm.ApplicationInfo ApplicationInfo
		{
			get
			{
				return getApplicationInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo2998;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getApplicationInfo2998)) as android.content.pm.ApplicationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getApplicationInfo2998)) as android.content.pm.ApplicationInfo;
		}
		public new global::java.lang.String PackageResourcePath
		{
			get
			{
				return getPackageResourcePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageResourcePath2999;
		public override global::java.lang.String getPackageResourcePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getPackageResourcePath2999)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageResourcePath2999)) as java.lang.String;
		}
		public new global::java.lang.String PackageCodePath
		{
			get
			{
				return getPackageCodePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageCodePath3000;
		public override global::java.lang.String getPackageCodePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getPackageCodePath3000)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageCodePath3000)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences3001;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getSharedPreferences3001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getSharedPreferences3001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _openFileInput3002;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._openFileInput3002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openFileInput3002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileOutput3003;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._openFileOutput3003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openFileOutput3003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _deleteFile3004;
		public override bool deleteFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._deleteFile3004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._deleteFile3004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath3005;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getFileStreamPath3005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getFileStreamPath3005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _fileList3006;
		public override global::java.lang.String[] fileList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._fileList3006)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._fileList3006)) as java.lang.String[];
		}
		public new global::java.io.File FilesDir
		{
			get
			{
				return getFilesDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilesDir3007;
		public override global::java.io.File getFilesDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getFilesDir3007)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getFilesDir3007)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalFilesDir3008;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getExternalFilesDir3008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getExternalFilesDir3008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		public new global::java.io.File CacheDir
		{
			get
			{
				return getCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheDir3009;
		public override global::java.io.File getCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getCacheDir3009)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getCacheDir3009)) as java.io.File;
		}
		public new global::java.io.File ExternalCacheDir
		{
			get
			{
				return getExternalCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExternalCacheDir3010;
		public override global::java.io.File getExternalCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getExternalCacheDir3010)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getExternalCacheDir3010)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getDir3011;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getDir3011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getDir3011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase3012;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._openOrCreateDatabase3012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openOrCreateDatabase3012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _deleteDatabase3013;
		public override bool deleteDatabase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._deleteDatabase3013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._deleteDatabase3013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath3014;
		public override global::java.io.File getDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getDatabasePath3014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getDatabasePath3014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _databaseList3015;
		public override global::java.lang.String[] databaseList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._databaseList3015)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._databaseList3015)) as java.lang.String[];
		}
		public new global::android.graphics.drawable.Drawable Wallpaper
		{
			get
			{
				return getWallpaper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaper3016;
		public override global::android.graphics.drawable.Drawable getWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getWallpaper3016)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaper3016)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _peekWallpaper3017;
		public override global::android.graphics.drawable.Drawable peekWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._peekWallpaper3017)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._peekWallpaper3017)) as android.graphics.drawable.Drawable;
		}
		public new int WallpaperDesiredMinimumWidth
		{
			get
			{
				return getWallpaperDesiredMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth3018;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth3018);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth3018);
		}
		public new int WallpaperDesiredMinimumHeight
		{
			get
			{
				return getWallpaperDesiredMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight3019;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight3019);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight3019);
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper3020;
		public override void setWallpaper(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._setWallpaper3020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setWallpaper3020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper3021;
		public override void setWallpaper(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._setWallpaper3021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setWallpaper3021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearWallpaper3022;
		public override void clearWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._clearWallpaper3022);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._clearWallpaper3022);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity3023;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._startActivity3023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startActivity3023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender3024;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._startIntentSender3024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startIntentSender3024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast3025;
		public override void sendBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendBroadcast3025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendBroadcast3025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast3026;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendBroadcast3026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendBroadcast3026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast3027;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendOrderedBroadcast3027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendOrderedBroadcast3027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast3028;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendOrderedBroadcast3028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendOrderedBroadcast3028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyBroadcast3029;
		public override void sendStickyBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendStickyBroadcast3029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendStickyBroadcast3029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyOrderedBroadcast3030;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendStickyOrderedBroadcast3030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendStickyOrderedBroadcast3030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _removeStickyBroadcast3031;
		public override void removeStickyBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._removeStickyBroadcast3031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._removeStickyBroadcast3031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver3032;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._registerReceiver3032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._registerReceiver3032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver3033;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._registerReceiver3033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._registerReceiver3033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _unregisterReceiver3034;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._unregisterReceiver3034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._unregisterReceiver3034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startService3035;
		public override global::android.content.ComponentName startService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._startService3035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startService3035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _stopService3036;
		public override bool stopService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._stopService3036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._stopService3036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService3037;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._bindService3037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._bindService3037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unbindService3038;
		public override void unbindService(android.content.ServiceConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._unbindService3038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._unbindService3038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInstrumentation3039;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._startInstrumentation3039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startInstrumentation3039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService3040;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getSystemService3040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getSystemService3040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingPermission3041;
		public override int checkCallingPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkCallingPermission3041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingPermission3041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfPermission3042;
		public override int checkCallingOrSelfPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkCallingOrSelfPermission3042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingOrSelfPermission3042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforcePermission3043;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforcePermission3043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforcePermission3043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingPermission3044;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceCallingPermission3044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingPermission3044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfPermission3045;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceCallingOrSelfPermission3045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingOrSelfPermission3045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _grantUriPermission3046;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._grantUriPermission3046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._grantUriPermission3046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _revokeUriPermission3047;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._revokeUriPermission3047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._revokeUriPermission3047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission3048;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkUriPermission3048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkUriPermission3048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission3049;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkUriPermission3049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkUriPermission3049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingUriPermission3050;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkCallingUriPermission3050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingUriPermission3050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfUriPermission3051;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkCallingOrSelfUriPermission3051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingOrSelfUriPermission3051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission3052;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceUriPermission3052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceUriPermission3052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission3053;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceUriPermission3053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceUriPermission3053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingUriPermission3054;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceCallingUriPermission3054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingUriPermission3054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfUriPermission3055;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission3055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission3055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPackageContext3056;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._createPackageContext3056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._createPackageContext3056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isRestricted3057;
		public override bool isRestricted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._isRestricted3057);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._isRestricted3057);
		}
		internal static global::MonoJavaBridge.MethodId _ContextWrapper3058;
		public ContextWrapper(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._ContextWrapper3058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContextWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContextWrapper"));
			global::android.content.ContextWrapper._getClassLoader2985 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::android.content.ContextWrapper._checkPermission2986 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			global::android.content.ContextWrapper._getResources2987 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.ContextWrapper._getPackageName2988 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._attachBaseContext2989 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V");
			global::android.content.ContextWrapper._getBaseContext2990 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getBaseContext", "()Landroid/content/Context;");
			global::android.content.ContextWrapper._getAssets2991 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.ContextWrapper._getPackageManager2992 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			global::android.content.ContextWrapper._getContentResolver2993 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.content.ContextWrapper._getMainLooper2994 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.content.ContextWrapper._getApplicationContext2995 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			global::android.content.ContextWrapper._setTheme2996 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "setTheme", "(I)V");
			global::android.content.ContextWrapper._getTheme2997 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.ContextWrapper._getApplicationInfo2998 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			global::android.content.ContextWrapper._getPackageResourcePath2999 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._getPackageCodePath3000 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._getSharedPreferences3001 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			global::android.content.ContextWrapper._openFileInput3002 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.content.ContextWrapper._openFileOutput3003 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.content.ContextWrapper._deleteFile3004 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.content.ContextWrapper._getFileStreamPath3005 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._fileList3006 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.content.ContextWrapper._getFilesDir3007 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getExternalFilesDir3008 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._getCacheDir3009 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getExternalCacheDir3010 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getExternalCacheDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getDir3011 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			global::android.content.ContextWrapper._openOrCreateDatabase3012 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.content.ContextWrapper._deleteDatabase3013 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.content.ContextWrapper._getDatabasePath3014 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._databaseList3015 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.content.ContextWrapper._getWallpaper3016 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.ContextWrapper._peekWallpaper3017 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth3018 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight3019 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.content.ContextWrapper._setWallpaper3020 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::android.content.ContextWrapper._setWallpaper3021 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::android.content.ContextWrapper._clearWallpaper3022 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "clearWallpaper", "()V");
			global::android.content.ContextWrapper._startActivity3023 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._startIntentSender3024 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.content.ContextWrapper._sendBroadcast3025 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._sendBroadcast3026 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._sendOrderedBroadcast3027 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContextWrapper._sendOrderedBroadcast3028 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._sendStickyBroadcast3029 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._sendStickyOrderedBroadcast3030 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContextWrapper._removeStickyBroadcast3031 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._registerReceiver3032 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			global::android.content.ContextWrapper._registerReceiver3033 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.content.ContextWrapper._unregisterReceiver3034 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::android.content.ContextWrapper._startService3035 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::android.content.ContextWrapper._stopService3036 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			global::android.content.ContextWrapper._bindService3037 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.content.ContextWrapper._unbindService3038 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::android.content.ContextWrapper._startInstrumentation3039 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.content.ContextWrapper._getSystemService3040 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.ContextWrapper._checkCallingPermission3041 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			global::android.content.ContextWrapper._checkCallingOrSelfPermission3042 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			global::android.content.ContextWrapper._enforcePermission3043 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingPermission3044 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingOrSelfPermission3045 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._grantUriPermission3046 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::android.content.ContextWrapper._revokeUriPermission3047 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::android.content.ContextWrapper._checkUriPermission3048 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.content.ContextWrapper._checkUriPermission3049 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.content.ContextWrapper._checkCallingUriPermission3050 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.ContextWrapper._checkCallingOrSelfUriPermission3051 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.ContextWrapper._enforceUriPermission3052 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceUriPermission3053 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingUriPermission3054 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission3055 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.ContextWrapper._createPackageContext3056 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			global::android.content.ContextWrapper._isRestricted3057 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "isRestricted", "()Z");
			global::android.content.ContextWrapper._ContextWrapper3058 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
