using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_Library;

namespace SecondCalculator {
    public partial class Form1 : Form {

        string unitDigit = "";
        List<string> AllSpace = new List<string>();
        bool IsThereOperationInFrontOfDigit = false;
        int leftBraket = 0;
        int rightBraket = 0;
        List<string> TempSpaceForTringon = new List<string>();
        bool trigonFuncsExist = false;
        int whichTrigonFunc = 0;

        public Form1() {
            InitializeComponent();
            ordering.setupGame();
        }

        private void numberClick(object sender, EventArgs e) {

            Button button = (Button)sender;

            if (TextBox.Text == "0") {
                TextBox.Clear();
            }

            if (IsThereOperationInFrontOfDigit) {
                //unitDigit = "";
                TextBox.Clear();
                IsThereOperationInFrontOfDigit = false;
            }
                        
            unitDigit += button.Text;                        
            TextBox.Text += button.Text;
            
        }

        private void operatorClick(object sender, EventArgs e) {

            //사칙연산(+ - * / ) 의 경우, 처음으로 unitDigit를 처리함
            if (displayArea.Text == "0") {
                displayArea.Text = "";
            }
            
            //123
            AllSpace.Add(unitDigit);
            displayArea.Text += unitDigit;

            // +
            Button button = (Button)sender;
            AllSpace.Add(button.Text);            
            displayArea.Text += button.Text;
            
            // 33+ 에서 21을 입력 했을 때
            unitDigit = "";
            IsThereOperationInFrontOfDigit = true;
        }

        private void equalClick(object sender, EventArgs e) {

            equalFunc(AllSpace);            
        }

        double equalFunc(List<string> AllSpace) {
            
            // dispayArea공간에 0이 있다면 없애버리고!!
            if (displayArea.Text == "0") {
                displayArea.Text = "";
            }

            // 12+ 34에서 34를 AllSpace공간에 넣어주기 위함 
            if (unitDigit != "") {
                AllSpace.Add(unitDigit);
                displayArea.Text += unitDigit;
            }

            // TextBox 공간은 final result를 보여주기 위한 공간. 이전 이 공간이 filled되었다면 remove하고 refresh!!!
            TextBox.Clear();                       

            // AllSpace공간은 중간중간에 "" empty Value를 가짐. 실질 계산을 위해서 empty Value를 remove!!!
            while (AllSpace.Contains("")) {
                AllSpace.Remove("");
            }

            // (13*14)+ 이 처럼 불완전한 수식을 correct!! 접근하는 공간은 AllSpace공간이고 (13*14)+0 과 같이 modified Value 얻어짐
            CorrectError(AllSpace);

            // AllSpace공간을 재배치 시켜준 후 실제 연산을 해주는 과정
            List<string> newSpace = ordering.relocation(AllSpace);
            double result = ordering.realCalc(newSpace);
            TextBox.Text = result.ToString();


            // Test Final Value to access AllSpace공간
            /*
            for (int i = 0; i < AllSpace.Count() - 1; i++) {
                TextBox.Text += AllSpace[i];
            }
            */
            return result;
        }

        private void braketClick(object sender, EventArgs e) {

            if (displayArea.Text == "0") {
                displayArea.Text = "";
            }
            Button button = (Button)sender;

            // (12+34) -- 10*(11+12) -- (10+11)*12 -- (10+11) * (12*13)
            if (button.Text == "(") {
                leftBraket++;
                unitDigit = "";
                AllSpace.Add(button.Text);
                displayArea.Text += button.Text;

            } else if (button.Text == ")") {
                
                rightBraket++;
                AllSpace.Add(unitDigit);                
                displayArea.Text += unitDigit;
                unitDigit = "";
                AllSpace.Add(button.Text);
                displayArea.Text += button.Text;

                if (trigonFuncsExist && leftBraket == rightBraket) {

                    // 1+ sin(45*2) -- tan(22.5*2) + 1                    
                    //여기서 AllSpace는 45*2 and 22.5*2와 같은 내부 값을 계산하는데 사용                    
                    double tempResult = equalFunc(AllSpace);
                    // sin(45*2)와 tan(22.5*2)의 결과값 반환
                    double trigonValue = whichTrigonFuncs(whichTrigonFunc, tempResult);
                    //왜 unitDigit를 비우는가?
                    unitDigit = "";

                    //backup해 두었던 TempSpaceForTringon을 다시 AllSpace에....
                    AllSpace = new List<string>(TempSpaceForTringon);
                    // 1+에 Trigon의 결과값을 AllSpace에 넣어줌 1+sin(45*2)
                    AllSpace.Add(trigonValue.ToString());
                    //다시 삼각함수가 사용될 수 있으므로 TempSpaceForTringon 또한 백업
                    TempSpaceForTringon = new List<string>();

                    //내부 계산을 위해 사용되었던 값들 다시 원위치? 왜? 이후 추가적인 계산을 하기 위해서
                    IsThereOperationInFrontOfDigit = false;
                    leftBraket = 0;
                    rightBraket = 0;
                    ordering.setupGame();
                    trigonFuncsExist=false;
                }
            }

        }

        double whichTrigonFuncs(int which,double value) {

            double result = 0;
            if (which == 1) {
                result = Math.Sin(Math.PI * value / 180.0);
            } else if(which == 2) {
                result = Math.Cos(Math.PI * value / 180.0);
            } else if (which == 3) { 
                result = Math.Tan(Math.PI * value / 180.0);
            } else if(which == 4) {
                result = Math.Exp(value);
            } else if (which == 5) {
                result = Math.Sqrt(value);
            } else if (which == 6) {
                result = Math.Log10(value);
            } else if (which == 7) {
                result = Math.Log(value);
            }
            return result;
        }

        private void clearClick(object sender, EventArgs e) {

            clearFunc();
        }

        void clearFunc() {

            unitDigit = "";
            AllSpace = new List<string>();
            IsThereOperationInFrontOfDigit = false;
            leftBraket = 0;
            rightBraket = 0;
            ordering.setupGame();
            displayArea.Text = "0";
            TextBox.Text = "0";
        }

        void CorrectError(List<string> AllSpace) {

            //List<string> newSpace = new List<string>();
            int value = whatIsLast(AllSpace);

            if (leftBraket != rightBraket) {
                                               
                if (leftBraket > rightBraket) {

                    // 숫자로 끝난 경우
                    if (value == 1) {
                        
                    }else if(value == 2) {

                        // 연산자로 끝난 경우
                        if (AllSpace[AllSpace.Count() - 1] == "*" || AllSpace[AllSpace.Count() - 1] == "/") {
                            AllSpace.Add("1");
                            displayArea.Text += "1";
                        } else {
                            AllSpace.Add("0");
                            displayArea.Text += "0";
                        }

                    } else if(value == 3) {
                        // ) 로 끝난 경우
                    }

                    while (leftBraket != rightBraket) {
                        AllSpace.Add(")");
                        displayArea.Text += ")";
                        rightBraket++;
                    }
                }

            } else {
                //braket의 수가 서로 같은 경우
                
                if(whatIsLast(AllSpace) == 1) {
                    //숫자로 끝날 때
                } else if (whatIsLast(AllSpace) == 2) {
                    //연산자로 끝날 떄
                    if(AllSpace[AllSpace.Count()-1] == "*" || AllSpace[AllSpace.Count() - 1] == "/") {
                        AllSpace.Add("1");
                        displayArea.Text += "1";
                    } else {
                        AllSpace.Add("0");
                        displayArea.Text += "0";
                    }
                } else if(whatIsLast(AllSpace) == 3) {

                }
            }            
        }

        private void deleteClick(object sender, EventArgs e) {
            //목적은 unitDigit의 하나의 값을 삭제해 준다.
            // 삭제할 값이 없을때는 0을 반환해준다.
            
            if (unitDigit.Length == 1) {
                unitDigit = "";
                TextBox.Text = "0";
            }else {
                unitDigit = unitDigit.Remove(unitDigit.Length - 1);
                TextBox.Text = unitDigit;
            }
        }

        private void trigonFuncs(object sender, EventArgs e) {

            if (displayArea.Text == "0") {
                displayArea.Text = "";
            }
            Button button = (Button)sender;

            // TempSpaceForTringon 을 AllSpace로 복사해서 새로운 공간으로 만듬... not the same
            TempSpaceForTringon = new List<string>(AllSpace);
            // AllSpace를 backup
            AllSpace = new List<string>();

            //모든 값 초기화 시킴? 왜?
            IsThereOperationInFrontOfDigit = false;
            leftBraket = 0;
            rightBraket = 0;
            ordering.setupGame();            
            TextBox.Clear();

            //이건 뭐지?
            trigonFuncsExist = true;

            AllSpace.Add("(");
            leftBraket++;
            unitDigit = "";

            if (button.Text == "sin") {                
                displayArea.Text += button.Text;
                whichTrigonFunc = 1;
            } else if(button.Text == "cos") {
                displayArea.Text += button.Text;
                whichTrigonFunc = 2;
            } else if (button.Text == "tan") {
                displayArea.Text += button.Text;
                whichTrigonFunc = 3;
            } else if(button.Text == "e^x") {
                displayArea.Text += "e^";
                whichTrigonFunc = 4;
            } else if(button.Text == "√") {
                displayArea.Text += button.Text;
                whichTrigonFunc = 5;
            } else if(button.Text == "log") {
                displayArea.Text += button.Text;
                whichTrigonFunc = 6;
            } else if (button.Text == "ln") {
                displayArea.Text += button.Text;
                whichTrigonFunc = 7;
            }
            displayArea.Text += "(";
        }

        int whatIsLast(List<string> AllSpace) {

            int howMany = AllSpace.Count();

            string lastValue = AllSpace[howMany - 1];
            
            //연산자나 braket으로 끝난 경우
            //string lastSecondValue = Space[howMany - 2];
            if(lastValue == "+" || lastValue == "-" || lastValue == "*" || lastValue == "/") {
                return 2;
            }else if (lastValue == ")") {
                return 3;
            }else if( lastValue == "(") {
                return 4;
            }else if( lastValue == "") {
                return 5;
            }else{
                return 1;
            }                        
        }

        private void factoFunc(object sender, EventArgs e) {
            //string unitDigit가 자연수여야만 해!
            bool isNumeric = false;
            double num = 0;
            int result = 0;

            if (displayArea.Text == "0") {
                displayArea.Text = "";
            }

            if (unitDigit != "") {

                isNumeric = double.TryParse(unitDigit, out num);
                if (isNumeric) {
                    if (num - Math.Truncate(num) == 0) {
                        //자연수일때
                        int data = Convert.ToInt32(num);
                        result=MathCollections.factoFunc(data);

                        displayArea.Text += data + "!";
                        //TextBox.Text = result.ToString();
                        AllSpace.Add(result.ToString());
                        unitDigit = "";
                    }else {
                        //자연수 아닐때        
                        clearFunc();
                        displayArea.Text = "Error occurs. You should input correct data. Click Clear Again!";
                    }
                }else {
                    
                }
            }
        }
    }
}
