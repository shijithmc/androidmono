﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoJavaBridge
{
    public abstract class JavaException : Exception, IJavaObject
    {
        internal JniGlobalHandle mJvmHandle;

        public JniGlobalHandle JvmHandle
        {
            get { return mJvmHandle; }
        }

        bool mIsClrObject;
        public virtual bool IsClrObject
        {
            get
            {
                return mIsClrObject;
            }
        }
        
        public JavaException(JNIEnv env)
        {
            Type type = GetType();
            mIsClrObject = type.GetCustomAttributes(typeof(JavaClassAttribute), false).Length == 0 && type.GetCustomAttributes(typeof(JavaProxyAttribute), false).Length == 0;
        }
        
        public void Init(JNIEnv env, JniLocalHandle handle)
        {
            mJvmHandle = env.NewGlobalRef(handle);
        }
    }
}
