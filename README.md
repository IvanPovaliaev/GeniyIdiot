# 🎓GeniyIdiot
🧠**Шуточная** программа «Гений-Идиот» для оценки интеллектуальных способностей пользователей, написанная в процессе изучания принципов **ООП**, файловой системы хранения данных и тихнологии **Windows Forms**. Реализована в виде консольного приложения на C# и Windows Forms.

Интерфейс консольного приложения:
<div " align="center">
  
![image](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/c1e3ba90-214b-4d08-9d43-4227e7e5d635)
  
</div>

Интерфейс приложения на WinForms:
<div " align="center">
  
![image](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/266b50a9-c862-49e5-a288-dae95a552855)

</div>

## 📝Описание работы
Программа создана для тестирования пользователя и постановки ему ***"диагноза"*** на основе количества правильных ответов.
Количество времени для ответа на каждый вопрос ограничено 10 сек. Пользователь может в реальном времени увидеть, сколько у него осталось времени с помощью таймера.

По умолчанию доступно 5 вопросов, но их количество можно изменить с помощью функции меню ***"Вопросы"***. При этом не может быть меньше 1 вопроса.<br />
Вопросы задаются в случайно порядке. <br />
Имеется возможность просмотра и очистки результатов всех тестирований.<br />
Имеется возможность смены текущего пользователя.<br />

Приложение реализовано в двух вариантах:
1. Консольное приложение;
2. Оконное приложение на Windows Forms.

### 📁GeniyIdiotConsoleApp
Пример работы консольного приложения приведён ниже:
<div " align="center">
  
https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/85579b19-f2d7-4d1b-b2a0-6795a51341a7

</div>

### 🖥️GeniyIdiotWinFormsApp
Пример работы приложения на WinForms приведён ниже:

<div " align="center">
  
https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/8ea52fdb-a026-43f1-bfc0-867e7e82d798

</div>

## 🛠️Техническая часть

Проект выполнен с соблюдением принципов **ООП** и использованием **LINQ**.
Хранение вопросов и результатов осуществляется в отдельных файлах файловой системы с сериализацией/дисериализацией в **JSON** с использованием библиотеки *Newtonsoft.Json*.

Решение разбито на 3 составляющие:
1. Проект консольного приложения **GeniyIdiotConsoleApp**;
2. Проект приложения на WinForms **GeniyIdiotWinFormsApp**;
3. Проект общей библиотеки **GeniyIdiot.Common** с реализацией общей логики работы приложений.

### 🏗️Архитектура

Структура каталога решения:<br />


<div " align="center">
  
  ![image](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/8229adf0-4364-4f25-b940-e7869d826ba4) ![image](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/c7f8421a-6cad-4b1a-b4f1-b37cee85b2e4) ![image](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/dd0c476e-0d31-4229-8496-6d444ce87882)
  
</div>
  
### 🔀Перемешивание вопросов:<br />
Для перемешивания вопросов перед каждым тестированием использовался алгоритм тасования Фишера-Йетса, реализованный в виде метода расширения Shuffle для коллекции обобщённого типа:  <br />

```csharp
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> array)
        {
            var List = array.ToList();

            for (int i = 0; i < List.Count; i++)
            {
                var randomIndex = new Random().Next(0, List.Count - 1);
                (List[i], List[randomIndex]) = (List[randomIndex], List[i]);
            }

            return List;
        }
```

### ⏱️Реализация таймера:<br />

Таймер был реализован с помощью класса **System.Timers.Timer**. <br />
Для соблюдения принципа DRY логика создания таймера была выделена в метод StartCoundown класса Game общей библиотеки GeniyIdiot.Common <br />

```csharp
	public void StartCountdown(ISynchronizeInvoke synchObject, Action DoInTick, Action DoAfterEnd)
	{
		IsTimerEnd = false;
		timersSeconds = TimersSecondsLimit;
		DoInTick();

		Countdown = new System.Timers.Timer(1000);
		Countdown.SynchronizingObject = synchObject;

		Countdown.Elapsed += (sender, e) =>
		{
			timersSeconds--;
			DoInTick();
			if (timersSeconds == 0)
			{
				IsTimerEnd = true;
				Countdown.Stop();
				DoAfterEnd();
			}
		};

		Countdown.Start();
	}
```

