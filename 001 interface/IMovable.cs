using System;
using System.Collections.Generic;
using System.Text;

namespace _001_interface
{
    interface IMovable
    {
        // константа
        const int minSpeed = 0;     // минимальная скорость
                                    // статическая переменная
        static int maxSpeed = 60;   // максимальная скорость
                                    // метод
        void Move();                // движение
                                    // свойство
        string Name { get; set; }   // название

        delegate void MoveHandler(string message);  // определение делегата для события
                                                    // событие
        event MoveHandler MoveEvent;    // событие движения
    }
}
