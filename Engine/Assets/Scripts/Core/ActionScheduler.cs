using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts.Core
{
    public class ActionScheduler : MonoBehaviour
    {
        private IAction _currentAction;
        
        public void StartAction(IAction action)
        {
            if (action == _currentAction) return;
            _currentAction?.Cancel();
            _currentAction = action;

        }

        public void CancelCurrentAction()
        {
            StartAction(null);
        }
    }
}
