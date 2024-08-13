/**
 * @authors chendichi
 * @date    2024-07-16 10:40:02
 * @version 1.0.0
 */

using System;
using System.Collections.Generic;

namespace GameFramework.Fsm
{
    /// <summary>
    /// 有限状态机接口
    /// </summary>
    /// <typeparam name="T">有限状态机持有者</typeparam>
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
        FsmState<T> CurrentState
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
        
        /// <summary>
        /// 开始有限状态机
        /// </summary>
        /// <typeparam name="TState">要开始的有限状态机状态类型</typeparam>
        void Start<TState>() where TState : FsmState<T>;
        
        /// <summary>
        /// 开始有限状态机
        /// </summary>
        /// <param name="stateType">要开始的有限状态机状态类型</param>
        void Start(Type stateType);
        
        /// <summary>
        /// 是否存在有限状态机状态
        /// </summary>
        /// <typeparam name="TState">要检查的有限状态机状态类型</typeparam>
        /// <returns></returns>
        bool HasState<TState>() where TState : FsmState<T>;
        
        /// <summary>
        /// 是否存在有限状态机状态
        /// </summary>
        /// <param name="stateType">要检查的有限状态机状态类型</param>
        /// <returns></returns>
        bool HasState(Type stateType);
        
        /// <summary>
        /// 获取有限状态机状态
        /// </summary>
        /// <typeparam name="TState">要获取的有限状态机状态</typeparam>
        /// <returns></returns>
        TState GetState<TState>() where TState : FsmState<T>;
        
        /// <summary>
        /// 获取有限状态机状态
        /// </summary>
        /// <param name="stateType">要获取的有限状态机状态</param>
        /// <returns></returns>
        FsmState<T> GetState(Type stateType);
        
        /// <summary>
        /// 获取有限状态机的所有状态
        /// </summary>
        /// <param name="results">有限状态机的所有状态</param>
        void GetAllStates(List<FsmState<T>> results);
        
        /// <summary>
        ///  是否存在状态机数据
        /// </summary>
        /// <param name="name">有限状态机数据名称</param>
        /// <returns></returns>
        bool HasData(string name);
        
        // TData GetData<TData>(string name) where TData : Variable;
    }
}

