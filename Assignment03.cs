using System;
using doit_study_homework_template.testcase;
using System.Collections.Generic;

namespace doit_study_homework_template
{
    public class Assignment03 : TestCase03, IAssignment
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public Assignment03(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
         public void main(){
            var inputs = input();
            var results = new List<int>();

            foreach (TestCase data in inputs){
                var numArr = data.numArr;
                var res = -100000000000;

                //res에 배열 numArr 안에서 가장 큰 수를 저장해주세요! (int형)
                //여기에 코드를 작성해주세요.
                foreach(var tmp in numArr)
                    res = (res<tmp) ? tmp : res;
                    
                results.Add((int)res);
            }

            output(results.ToArray());
        }
    }
}