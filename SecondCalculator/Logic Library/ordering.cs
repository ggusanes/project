using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundamental_Library;

namespace Logic_Library {
    static public class ordering {

        static public stack operations;

        static public void setupGame() {
            operations = new stack();
        }

        static public int prioritizeOperation(string operation) {

            int result = -1;
            switch (operation) {
                case "+":
                case "-":
                    result = 2;
                    break;
                case "*":
                case "/":
                    result = 3;
                    break;
                case "(":
                    result = 1;
                    break;
            }
            return result;
        }

        static public bool bfBiggerThanAf(string bf, string af) { //bf와 af는 연산자

            bool result = false;
            if (prioritizeOperation(bf) >= prioritizeOperation(af)) {
                result = true;
            } else if (prioritizeOperation(bf) < prioritizeOperation(af)) {
                result = false;
            }
            return result;
        }

        static public List<string> relocation(List<string> collection) {
            // 13 + 21 --> 13 21 + 
            // 3+2*4   3*2+4
            double num = 0;
            bool isNumeric = false;
            List<string> newSpace = new List<string>();

            for (int i = 0; i < collection.Count(); i++) {

                isNumeric = double.TryParse(collection[i], out num);
                if (isNumeric) {
                    newSpace.Add(num.ToString());
                } else {
                    //연산자라면
                    //비어있다면?
                    if (operations.IsEmpty()) {
                        operations.stackInsert(collection[i]);
                    } else {
                        //operations 스택에 무엇인가 있다면
                        if (collection[i] == "(") {

                            operations.stackInsert(collection[i]);

                        } else if (collection[i] == ")") {
                            //다 꺼내라고 untill 스텍의 값이 ( 나올때까지
                            while (operations.check() != "(") {
                                newSpace.Add(operations.putOut());
                            }
                            operations.putOut();
                        } else {
                            //일반 연산자라면
                            if (bfBiggerThanAf(operations.check(), collection[i])) {
                                //bf가 더 크다면
                                newSpace.Add(operations.putOut()); // * + 에서 *를 먼저 꺼내
                                operations.stackInsert(collection[i]);
                            } else {
                                //af가 더 크다면
                                operations.stackInsert(collection[i]);
                            }
                        }
                    }
                }
            }

            while (!operations.IsEmpty()) {
                newSpace.Add(operations.putOut()); //꺼낼때, 항상 고려해야 할것은 stack에 꺼낼 대상이 있냐는 것?
            }
            return newSpace;
        }

        static public double realCalc(List<string> Recollection) {

            bool isNumeric = false;
            double num = 0;
            stack digits = new stack();
            double data1 = 0;
            double data2 = 0;
            double result = 0;

            for (int i = 0; i < Recollection.Count(); i++) {

                isNumeric = double.TryParse(Recollection[i], out num);

                if (isNumeric) {
                    digits.stackInsert(num.ToString());
                } else {
                    data1 = double.Parse(digits.putOut());
                    data2 = double.Parse(digits.putOut());

                    switch (Recollection[i]) {
                        case "+":
                            result = data2 + data1;
                            break;
                        case "-":
                            result = data2 - data1;
                            break;
                        case "*":
                            result = data2 * data1;
                            break;
                        case "/":
                            result = data2 / data1;
                            break;
                    }
                    digits.stackInsert(result.ToString());
                } // end else                
            } // end for
            result = double.Parse(digits.putOut());
            return result;
        } // end realCalc function
    }
}

