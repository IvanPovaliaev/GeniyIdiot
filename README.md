# GeniyIdiot
🧠Шуточная программа «Гений-Идиот» для оценки интеллектуальных способностей пользователей, написанная в виде консольного приложения приложений на C# и Windows Forms с использованием принципов ООП и файловой системы хранения данных.

Интерфейс консольного приложения:
![image](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/c1e3ba90-214b-4d08-9d43-4227e7e5d635)

Интерфейс приложения на WinForms:
![image](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/266b50a9-c862-49e5-a288-dae95a552855)

## Описание работы
Программа создана для тестирования пользователя и постановки ему "диагноза" на основе количества правильных ответов.
Количество времени для ответа на каждый вопрос ограничено 10 сек. Пользователь может в реальном времени увидеть, сколько у него осталось времени с помощью таймера.

По умолчанию доступно 5 вопросов, но их количество можно изменить с помощью функции меню "Вопросы". При этом не может быть меньше 1 вопроса.<br />
Имеется возможность просмотра и очистки результатов всех тестирований.<br />
Имеется возможность смены текущего пользователя.<br />

Приложение реализовано в двух вариантах:
1. Консольное приложение;
2. Оконное приложение на Windows Forms.

### 📁GeniyIdiotConsoleApp
Пример работы консольного приложения приведён ниже:
![Консольное](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/4219d07d-30e3-41e6-9f88-bca98d2f364c)


### 🖥️GeniyIdiotWinFormsApp
Пример работы приложения на WinForms приведён ниже:

## Техническая часть

Проект выполнен с соблюдением принципов ООП, LINQ.
Хранение вопросов и результатах осуществляется в отдельных файлах файловой системы с сериализацией/дисериализацией в JSON.

Решение разбито на 3 составляющие:
1. Проект консольного приложения GeniyIdiotConsoleApp;
2. Проект приложения на WinForms GeniyIdiotWinFormsApp;
3. Проект общей библиотеки GeniyIdiot.Common с реализацией общей логики работы приложений.

### Архитектура
Структура каталога решения:<br />
![image](https://github.com/IvanPovaliaev/GeniyIdiot/assets/157638990/e3d52747-79e4-4973-b2a3-bf2c64e3b72b)


