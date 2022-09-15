using System;

namespace Lesson10
{
    class Lesson10
    {
        static void Main(string[] args)
        {
            MyMethod();
        }

            public static void MyMethod()
            {
                int _posY = 12;
                string name = "Bill";
                bool _isRun = true;

                double _speed = 12.3;
                int _year = 22;
                string team = "WinnerTeam";
                //
                if (_posY < 10 && name[0] == 'I' || !_isRun)
                {
                    Console.WriteLine(true + 1.ToString()); //false
                }

                if (team == "WinnerTeAM" || !(name == "Dave" && _posY < 1000 || _isRun == true))
                {
                    Console.WriteLine(true + 2.ToString());//false
                }

                if (_year > 22 && _year != 22 || _speed > 12 && _speed < 13)
                {
                    Console.WriteLine(true + 3.ToString());//true
                }

                if (_isRun || (!_isRun || _isRun) || _isRun && _isRun)
                {
                    Console.WriteLine(true + 4.ToString());//true
                }
            }
      
    }
}
