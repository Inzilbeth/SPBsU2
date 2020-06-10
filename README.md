# SPBU tasks

---

## Homework

### Lesson #1

[C# introduction](https://drive.google.com/file/d/1i6rwx1B44_Ff2uI3oJyonemHN2akmzFd/view)

1. Посчитать факториал. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework1/1.1)*
2. Посчитать числа Фибоначчи. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework1/1.2)*
3. Отсортировать массив какой-либо из сортировок. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework1/1.3)*
4. Дан массив размерностью N x N, N - нечетное число. Вывести элементы массива при обходе его по спирали, начиная с центра. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework1/1.4)*
5. Отсортировать столбцы матрицы по первым элементам. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework1/1.5)*

### Lesson #2

[Object-oriented programming](https://drive.google.com/file/d/1nBOnVfOLV-NLXqyr5Jc6xSJjBTnullIf/view)

1. Написать связный список в виде класса. От списка хочется:
- Добавлять/удалять элемент по произвольной позиции, задаваемой целым числом.
- Узнавать размер, проверять на пустоту.
- Получать или устанавливать значение элемента по позиции, задаваемой целым числом. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework2/Task1)*
1. Написать хеш-таблицу в виде класса с использованием класса-списка из первой задачи. Должно быть можно добавлять значение в хеш-таблицу, удалять и проверять на принадлежность. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework2/Task2)*
2. Реализовать стековый калькулятор (класс, реализующий выполнение операций +, -, *, / над арифметическим выражением в виде строки в постфиксной записи). Строка уже дана в обратной польской записи (например, 1 2 3 +* ). Стек реализовать двумя способами (например, массивом или списком) в двух разных классах на основе одного интерфейса. Стековый калькулятор должен знать только про интерфейс стека. В Main надо спросить у пользователя, какой из вариантов стека он хочет, в зависимости от выбора создаётся объект одной из двух реализаций и передаётся калькулятору. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework2/Task3)*

### Lesson #3

[Unit testing](https://drive.google.com/file/d/1NvUV1pE78NB0JLzNhl94cpTHCtAsoedG/view)

1. Написать юнит-тесты к задаче 3 из предыдущего задания. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework3/Task1)*
2. Модифицировать хеш-таблицу из задачи 2 предыдущей работы так, чтобы хеш-функцию можно было менять в зависимости от выбора пользователя, причём хеш-функцию должно быть можно передавать из использующего хеш-таблицу кода в виде объекта некоторого класса, реализующего некоторый интерфейс. Хеш-функцию должно быть можно менять во время работы. Юнит-тесты и коментарии в формате XML Documentation обязательны. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework3/Task2)*

### Lesson #4

[Exceptions & error processing](https://drive.google.com/file/d/1YlaxygcAWXEZJcFnarkX7sm55a5gdFFV/view)

1. Решить задачу о вычислении выражения по дереву разбора из прошлого семестра. Реализовать иерархию классов, описывающих дерево разбора, используя их, реализовать класс, вычисляющий значение выражения по дереву. Классы, представляющие операнды и операторы, должны сами уметь себя вычислять и печатать.

    Исходное условие:

    > По дереву разбора арифметического выражения вычислить его значение. Дерево разбора хранится в файле в виде (<операция> <операнд1> <операнд2>), где <операнд1> и <операнд2> сами могут быть деревьями, либо числами. Например, выражение (1 + 1) * 2 представляется в виде (* (+ 1 1) 2). Должны поддерживаться операции +, -, , / и целые числа в качестве аргументов. Требуется построить дерево в явном виде, распечатать его (не обязательно так же, как в файле), и посчитать значение выражения обходом дерева. Может быть полезна функция ungetc (если не ‘(’, возвращаем символ в поток и читаем число fscanf-ом). Можно считать, что входной файл корректен. Пример - по входному файлу ( (+ 1 1) 2) может печататься ( * ( + 1 1 ) 2 ) и выводиться 4.

    *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework4/Task1)*

2. Унаследовавшись от класса список, реализовать класс UniqueList, который не содержит повторяющихся значений. Реализовать классы исключений, которые генерируются при попытке добавления в такой список уже существующего или при попытке удаления несуществующего элемента. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework4/Task2)*

### Lesson #5

[Open source projects](https://drive.google.com/file/d/1f4T_SrK70UpFOeZhYVT0oJiIqbcHbNcL/view)

1. Настроить сборку на AppVeyor одной из предыдущих домашек. В качестве решения приложить ссылку на успешно собранный пуллреквест с appveyor.yml.

### Lesson #6

[Event-driven programming](https://drive.google.com/file/d/1xqsSGDcF2-mMA0szqsGC9HWQeupD__xo/view)

1. Реализовать функции Map, Filter и Fold:
    - Map принимает список и функцию, преобразующую элемент списка. Возвращаться должен список, полученный применением переданной функции к каждому элементу переданного списка. Например, `Map(new List<int>() {1, 2, 3}, x => x * 2)` должен возвращать список `[2; 4; 6]`.
    - Filter принимает список и функцию, возвращающую булевое значение по элементу списка. Возвращаться должен список, составленный из тех элементов переданного списка, для которых переданная функция вернула true.
    - Fold принимает список, начальное значение и функцию, которая берёт текущее накопленное значение и текущий элемент списка, и возвращает следующее накопленное значение. Сама Fold возвращает накопленное значение, получившееся после всего прохода списка. Например, `Fold(new List<int>() {1, 2, 3}, 1, (acc, elem) => acc * elem)` работала бы так: сначала в acc клался бы 1, потом умножался бы на 1, потом результат (1) умножался бы на 2, потом результат (2) умножался бы на 3, потом результат (6) возвращался бы в качестве ответа.

    Если умеете генерики, подумайте, как сделать тип функций наиболее общим. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework6/Task1)*

2. На базе класса, генерирующего события по нажатию на клавиши управления курсором (EventLoop с пары), реализовать консольное приложение, позволяющее управлять персонажем, перемещающимся по карте. Карта состоит из свободного пространства и стен, и должна грузиться из файла. Приложение должно отображать карту и персонажа (символом `@`) в окне консоли, и позволять персонажу перемещаться по карте, реагируя на клавиши управления курсором. Будут полезны свойства Console.CursorLeft и Console.CursorTop. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework6/Task2)*

### Lesson #7

[User interface (windows forms)](https://drive.google.com/file/d/1n__R8rjsxWyws2gnWBBymSjBZpnIgxMn/view)

1. Написать калькулятор с пользовательским интерфейсом (по примеру стандартного виндового калькулятора). *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework7/Task1)*
2. Сделать часы (приложение, показывающее текущее системное время) со стрелками (часовой, минутной и секундной). Здесь юнит-тесты можно не писать. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework7/Task2)*

### Lesson #8

[Writing a clean programming code](https://drive.google.com/file/d/1jK5ys0PDuCXGi08xQELTIaixIvUppzrm/view)

### Lesson #9

[Containers & generics](https://drive.google.com/file/d/1lapKvfGvN5IXQYA2PRRGyRCxOtIEwKgR/view)

1. Создать генерик-класс, реализующий АТД “Множество”. Множество должно реализовывать интерфейс System.Collections.Generic.ISet. Ожидается асимптотическая трудоёмкость основных операций не хуже в среднем логарифмической (то есть несбалансированное двоичное дерево тоже пойдёт). Проверить в тестах, что по множеству можно ходить foreach. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework9/Task1)*

### Lesson #10

[Visual modeling (UML)](https://drive.google.com/file/d/1-WOqEFvPq64vTMlYe-sChTEAIWjDf-a6/view)

1. Нарисовать на UML диаграмму классов для игры “реверси”, с несколькими видами “ботов”, которые могли бы играть вместо человека. Диаграмма должна быть довольно подробным проектом системы. Реализовывать этот проект не нужно. Желательно пользоваться средствами визуального моделирования наподобие Visual Paradigm ([https://www.visual-paradigm.com/download/community.jsp](https://www.visual-paradigm.com/download/community.jsp)), присылать скриншоты с диаграммой и исходники (файлы .vpp в случае Visual Paradigm). *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Homework10/Task1)*

---

## Tests

### #1

1. Реализовать генерик-очередь с приоритетами. Очередь должна иметь метод Enqueue(), принимающий на вход значение (типа, который параметр-тип в генерике) и численный приоритет, и метод Dequeue(), возвращающий значение с наивысшим приоритетом и удаляющий его из очереди. Если очередь пуста, Dequeue() должен бросать исключение. Комментарии и юнит-тесты обязательны, настроенный CI очень желателен. *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Test1/Task1)*

### #2

1. Реализовать игру "Найди пару". При запуске отображается поле с кнопками размера N x N (N передаётся как параметр при запуске), кнопки
без надписей. Каждой кнопке ставится в соответствие случайное число от 0 до N2 / 2. Игрок нажимает на две произвольные (разные)
кнопки, на них показываются соответствующие им числа. Если числа
совпали, кнопки делаются неактивными. Если числа не совпали, кнопки
через некоторое время возвращаются в изначальное положение. Игра
заканчивается, когда игрок открыл все пары чисел (программа должна
генерировать числа таким образом, чтобы это было возможно). *[SOLUTION](https://github.com/Inzilbeth/SPBsU/tree/master/Test2/Task1)*

