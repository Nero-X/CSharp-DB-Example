# CSharp-DB-Example
Данный проект представляет собой пример реализации приложения WinForms для работы с базой данных MySQL.

### Использованные технологии:
1. .NET Framework
2. C#
3. MySQL
4. Visual Studio 2019

## Базовый функционал

### Просмотр, добавление, изменение, удаление данных в таблицах
![image](https://user-images.githubusercontent.com/47949085/149527536-3db9015e-c5d8-4084-8ad5-4cf4628097f6.png)

### Фильтрация отображаемых данных
![image](https://user-images.githubusercontent.com/47949085/149528589-3d5633be-44c7-4b3b-acd2-28236cb211c5.png)

### Выполнение и сохранение запросов к БД на языке SQL
![image](https://user-images.githubusercontent.com/47949085/149528776-818d246c-b092-4a47-81b4-e2c88886875b.png)

При наличии в тексте запроса пользовательских параметров, при попытке выполнения запроса открывается форма выбора значений параметров.

![image](https://user-images.githubusercontent.com/47949085/149528862-19087b02-644f-4eec-8f0e-8995b28a195e.png)

## Открытие проекта в Visual Studio
### Зависимости:
NuGet пакеты:
- Microsoft.ReportingServices.ReportViewerControl.Winforms
- Microsoft.SqlServer.Types

Расширения:
- [MySQL Connector/NET](https://dev.mysql.com/downloads/connector/net/)
- [MySQL for Visual Studio](https://dev.mysql.com/downloads/windows/visualstudio/)
- Microsoft Reporting Services Projects (из Visual Studio Marketplace)
- Microsoft RDLC Report Designer (из Visual Studio Marketplace)

## Конфигурация приложения для работы с другой БД
1. Удалить содержимое папок DocumentForms и Reports
2. Удалить датасет service_centerDataSet 
3. Создать подключение и добавить датасет для своей БД
4. Удалить таблицы в reportsDataSet
5. Удалить строки в reportQueries.cs
6. Удалить HandleOperation в utility.cs

### Дизайнер MainForm:
7. Удалить все bindingSource и Adapter
8. Создать bindingSource и Adapter ко всем таблицам бд (быстрый способ: добавить на форму listbox и по очереди указать все таблицы своего датасета в качестве источника данных)
9. Удалить содержимое элементов меню Операции и Отчёты и обработчики нажатий в коде

### MainForm.cs:
10. Заменить ConnectionString
11. Перенести созданные в Form1_Load строки в метод fillAll
12. Скопировать эти строки в updateAll, заменив метод Fill на Update
13. В конструкторе MainForm заменить имеющиеся строки в словаре DataTableInfos на свои. Для каждой таблицы необходимо добавить строку следующего содержания: { НазваниеДатасета.НазваниеТаблицы, ("Выводимое название таблицы", номер столбца для отображения во внешних таблицах (если отсутствует ключевое поле - 0), соответствующийBindingSource) }
14. Заменить везде service_centerDataSet на название созданного датасета

Подготовка закончена и приложение готово к использованию. Для удобства можно добавить формы документов и отчёты.

## Добавление отчётов
1. Создать таблицу в reportsDataSet, которая будет содержать все поля для отображения в отчёте
2. Скопировать полученный запрос SQL и сохранить его как строку в файле reportQueries.cs
3. Создать отчёт используя мастер отчётов (добавление нового элемента в обозревателе решения). Имя набора данных всегда оставлять DataSet1. Источник данных - reportsDataSet. Доступные наборы данных - созданная таблица.
4. Для открытия отчёта использовать метод MainForm.ExecuteReport.
