# Snake
Введение

Змейка - классическая аркадная игра. Изначально разработанна для
игровых автоматов, она была перенесена на множество платформ, включая
ПК.
В этой курсовой работе реализована игра Змейка на языке
программирования C# с использованием библиотеки WinForms. Исследованы
концепции, лежащие в основе игры, такие как перемещение змеи, обработка
ввода с клавиатуры и генерация еды.
В ходе курсовой работы была разработана полноценная игра Змейка с
использованием C# и WinForms. Игра будет включать такие функции, как:
• Управление змейкой с помощью клавиш со стрелками
• Генерация случайной еды на игровом поле
• Определение столкновений между змейкой и едой, а также между
змейкой и самой собой
• Отображение счета и уровня сложности
Реализация этих функций позволит создать игру Змейка, которая будет
соответствовать классическому геймплею этой игры.


Методы

Работа с формами:

• InitializeComponent(): Вызывается в конструкторе формы для
инициализации визуальных компонентов, определенных в файле
Form1.Designer.cs.  

• this.Text = "Snake";: Устанавливает заголовок формы.  

• this.Width = _width; this.Height = _height;: Устанавливает размер формы.  

• this.Controls.Add(labelScore);: Добавляет элемент управления (в данном
случае, labelScore) на форму.  

• this.Controls.Add(snake[0]);: Добавляет элемент управления (в данном
случае, snake[0], голову змеи) на форму.  

• this.Controls.Add(fruit);: Добавляет элемент управления (в данном
случае, fruit) на форму.

• this.KeyDown += new KeyEventHandler(OKP);: Регистрирует
обработчик события нажатия клавиши (KeyDown) для формы.

Работа с графикой:

• snake[i].BackColor = Color.Red;: Устанавливает цвет фона элемента
управления (в данном случае, snake[i]) на красный.

• snake[i].Size = new Size(_sizeOfSides - 1, _sizeOfSides - 1);:
Устанавливает размер элемента управления (в данном случае, snake[i]).

• snake[i].Location = new Point(x, y);: Устанавливает положение элемента
управления (в данном случае, snake[i]) на форме.

Работа с событиями:

• timer.Tick += new EventHandler(_update);: Регистрирует обработчик
события Tick для таймера.

• this.KeyDown += new KeyEventHandler(OKP);: Регистрирует
обработчик события KeyDown для формы.

Работа с таймерами:

• timer = new Timer();: Создает новый экземпляр таймера.

• timer.Interval = 200;: Устанавливает интервал таймера (в
миллисекундах).

• timer.Start();: Запускает таймер.
