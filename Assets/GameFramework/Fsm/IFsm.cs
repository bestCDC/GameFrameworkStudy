/**
 * 有限状态机接口
 * @authors chendichi
 * @date    2024-07-16 10:40:02
 * @version 1.0.0
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Fsm
{
    public interface IFsm<T> where T : class
    {
        /// <summary>
        /// 获取有限状态机名称。
        /// </summary>
        String Name 
        {
            get;
        }

        /// <summary>
        /// 获取有限状态机完整名称。
        /// </summary>
        String FullName
        {
            get;
        }

        /// <summary>
        /// 获取有限状态机持有者。
        /// </summary>
        T Owner
        {
            get;
        }

        /// <summary>
        /// 获取有限状态机中状态的数量。
        /// </summary>
        int FsmStateCount
        {
            get;
        }   

        /// <summary>
        /// 获取有限状态机是否正在运行
        /// </summary>
        bool IsRunning
        {
            get;
        }

        /// <summary>
        /// 获取有限状态机是否被销毁。
        /// </summary>
        bool IsDestroyed
        {
            get;
        }

        /// <summary>
        /// 获取当前有限状态机状态。
        /// </summary>
        IFsm<T> CurrentState
        {
            get;
        }

        /// <summary>
        /// 获取当前有限状态机状态持续时间。
        /// </summary>
        float CurrentSateTime
        {
            get;
        }
    }
}

