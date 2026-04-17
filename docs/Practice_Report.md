# Отчёт по производственной практике  
по профессиональному модулю **ПП.02.01**

**Тема:** Организация репозитория и работа с Git на основе программного продукта курсового проекта. Разработка тестовой документации.

**Студент:** Ахмтезянов Р.В.
**Группа:** П-402
**Дата:** 15.04.2026

## 1. Ссылка на репозиторий
https://github.com/Radioon4800/practice-pm02-integration-testing

## 2. Граф коммитов (Git Graph)

![Git Graph][(https://github.com/Radioon4800/practice-pm02-integration-testing/blob/develop/docs/git-graph.png?raw=true](https://github.com/Radioon4800/practice-pm02-integration-testing/network))

## 3. Pull Request
- Ссылка: https://github.com/Radioon4800/practice-pm02-integration-testing/pull/1
- Из ветки `feature/add-tests` в `develop`
- Статус: **Merged**

## 4. Баг-репорт (Issue)
- Ссылка: https://github.com/Radioon4800/practice-pm02-integration-testing/issues/2
- Заголовок: Bug: Неправильные данные отчёта за Апрель
- Статус: **Open**

## 5. Тестовая документация
Файл: [`docs/TestCases.md`](https://github.com/Radioon4800/practice-pm02-integration-testing/blob/develop/docs/TestCases.md)

Разработано 6 тест-кейсов:
- TC-001 — Проверка отчёта за Март
- TC-002 — Проверка отчёта за Апрель
- TC-003 — Проверка неизвестного месяца
- TC-004 — Регистронезависимость
- TC-005 — Интеграционный тест UI
- TC-006 — Проверка статуса "Нет данных"

## 6. Структура проекта
- `module_A/AirQualityProcessor.cs` — модуль обработки данных качества воздуха (AQI)
- `module_B/AirQualityForm.cs` — модуль пользовательского интерфейса
- `tests/AirQualityProcessorTests.cs` — юнит-тесты
- `Program.cs` — точка входа приложения

## Заключение
В ходе практики освоены:
- Работа с Git (ветвление, коммиты, Pull Request, merge)
- Создание модульной структуры проекта
- Разработка тест-кейсов для модульного и интеграционного тестирования
- Оформление баг-репортов по стандарту

Практика позволила закрепить навыки командной разработки и тестирования программного обеспечения на основе реального курсового проекта «Анализ качества воздуха».
