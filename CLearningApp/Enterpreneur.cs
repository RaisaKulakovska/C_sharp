using System;
using System.Collections.Generic;
using System.Text;

namespace CLearningApp
{
    public class Enterpreneur : Employee
    {
        //Object's methods: ToString, GetHeshCode, GetType, Equals
        private int agreementNumber;
        public int GetAgreementNumber()
        {            
             return agreementNumber;
        }
        public void SetAgreementNumber(int value)
        {            
            agreementNumber = value;            
        }
    }
}