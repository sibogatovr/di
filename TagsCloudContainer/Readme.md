# TagsCloudContainer

Проект представляет собой программу для генерации облака тегов из файла с набором слов. Программа осуществляет удаление скучных слов, перечень которых указан в отдельном файле, а также приведение всех слов к нижнему регистру для унификации.

## Внесенные изменения:

- Добавлена функциональность удаления скучных слов.
- Реализовано приведение всех слов к нижнему регистру.
- Реализовано изменение цвета ТОП слов.
- Реализована возможность изменить шрифт, цвет, размер.
- Добавлен CLI.
- Реализованы ридеры: \*.doc, \*.docx, \*.txt.
- Добавлены соответствующие тесты для новой функциональности.
- Внесены мелкие улучшения и исправления.

## Исключение слов из облака

- Список слов которые надо исключить, находятся в файле 'boring_words.txt'