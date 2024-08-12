using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameFramework
{
    public static partial class ReferencePool
    {
        private static readonly Dictionary<Type, ReferenceCollection> s_ReferenceCollections =
            new Dictionary<Type, ReferenceCollection>();
        private static bool m_EnableStrictCheck = false;
        
        /// <summary>
        /// 获取或设置是否开启强制检查
        /// </summary>
        public static bool EnableStrictCheck
        {
            get
            {
                return m_EnableStrictCheck;
            }

            set
            {
                m_EnableStrictCheck = value;
            }
        }
        
        /// <summary>
        /// 获取引用池的数量
        /// </summary>
        public static int Count
        {
            get
            {
                return s_ReferenceCollections.Count;
            }
        }
        
        // /// <summary>
        // /// 获取所有引用池的信息
        // /// </summary>
        // /// <returns></returns>
        // public static ReferencePoolInfo[] GetAllReferencePoolInfos()
        // {
        //     int index = 0;
        //     ReferencePoolInfo[] results = null;
        //     
        //     
        // }
    }    
}

