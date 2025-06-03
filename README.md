# TreeLab

<div align="center">

![TreeLab Logo](https://img.shields.io/badge/TreeLab-v1.0-green?style=for-the-badge&logo=tree&logoColor=white)

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)

[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=flat-square&logo=windows)](https://www.microsoft.com/windows/)
[![AVL Trees](https://img.shields.io/badge/AVL-Trees-orange?style=flat-square)](https://en.wikipedia.org/wiki/AVL_tree)

**Интерактивное приложение Windows Forms для работы с бинарными деревьями и AVL-деревьями**

</div>

---

## 🌳 Содержание

- [🚀 Введение](#-введение)
- [✨ Возможности](#-возможности)
- [⚡ Установка](#-установка)
- [🎯 Использование](#-использование)
- [🔧 Зависимости](#-зависимости)
- [⚙️ Конфигурация](#️-конфигурация)
- [💡 Примеры](#-примеры)
- [🐛 Устранение неполадок](#-устранение-неполадок)

---

## 🚀 Введение

TreeLab помогает пользователям понять операции с бинарными деревьями, предлагая **визуальное представление** создания деревьев, проверки балансировки AVL и удаления узлов. Приложение включает интерактивную панель инструментов для выполнения различных операций с деревьями.

<div align="center">

**🎓 Идеальный инструмент для изучения алгоритмов и структур данных**

```
       🌳
      /   \
     🍃   🍃
    / \   / \
   🌿 🌿 🌿 🌿
```

</div>

---

## ✨ Возможности

<table>
<tr>
<td width="50%">

### 🛠 **Создание деревьев**
- Вставка узлов с символьными данными
- Поддержка ключевых значений
- Автоматическое построение структуры

### 🔄 **Преобразование деревьев**
- Логические модификации структуры
- Проверка AVL-условий
- Структурные изменения

</td>
<td width="50%">

### 🖼 **Визуализация**
- Графическое отображение узлов
- Визуализация связей между узлами
- Интерактивная панель рисования

### ⚖️ **AVL-балансировка**
- Проверка условий балансировки
- Автоматическая валидация дерева
- Индикация сбалансированности

</td>
</tr>
</table>

<div align="center">

| Функция | Описание | Статус |
|---------|----------|--------|
| ❌ **Удаление деревьев** | Полная очистка структуры данных | ✅ Реализовано |
| 📋 **Панель инструментов** | Интуитивное меню Windows Forms | ✅ Реализовано |
| 🎨 **Графический интерфейс** | Использование System.Drawing | ✅ Реализовано |

</div>

---

## ⚡ Установка

### Системные требования
![Windows](https://img.shields.io/badge/Windows-10/11-0078D6?style=flat&logo=windows&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2+-512BD4?style=flat&logo=dotnet&logoColor=white)
![Screen Resolution](https://img.shields.io/badge/Resolution-1606x875+-lightgrey?style=flat)

### Шаги установки

```bash
# 1. 📥 Клонируйте репозиторий
git clone <repository-url>
cd TreeLab
```

```bash
# 2. 🔨 Откройте в Visual Studio и соберите
# Ctrl+Shift+B
```

```bash
# 3. 🚀 Запустите приложение
# F5
```

> ⚠️ **Важно:** Убедитесь, что разрешение экрана поддерживает минимальный размер `1606x875`

---

## 🎯 Использование

### Главное меню

<div align="center">

| 🎛️ Раздел | 🔧 Функция | 📝 Описание |
|-----------|------------|-------------|
| **Задания** | Создание дерева | Построение нового бинарного дерева |
| **Задания** | Преобразование дерева | Модификация существующей структуры |
| **Задания** | Разрушение дерева | Полная очистка данных |
| **О программе** | Информация | Сведения о приложении |
| **Выход** | Завершение | Закрытие приложения |

</div>

### Рабочий процесс

```mermaid
graph LR
    A[🌱 Создать дерево] --> B[🔄 Преобразовать]
    B --> C[📊 Визуализировать]
    C --> D[⚖️ Проверить AVL]
    D --> E[❌ Удалить]
    E --> A
```

### Интерфейс

1. 🖱️ **Используйте меню** для выбора операций
2. 🎨 **Наблюдайте визуализацию** в главной панели
3. ✅ **Проверяйте результаты** балансировки
4. 🔄 **Экспериментируйте** с различными структурами

---

## 🔧 Зависимости

<div align="center">

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-Required-512BD4?style=for-the-badge&logo=dotnet)
![Windows Forms](https://img.shields.io/badge/System.Windows.Forms-Built--in-0078D4?style=for-the-badge)
![System.Drawing](https://img.shields.io/badge/System.Drawing-Built--in-FF6B6B?style=for-the-badge)

**🎉 Внешние пакеты NuGet не требуются!**

</div>

### Встроенные зависимости
- `System.Windows.Forms` - для GUI
- `System.Drawing` - для графической визуализации
- `System.Collections` - для структур данных

---

## ⚙️ Конфигурация

> 🎛️ **Простота использования:** Дополнительная конфигурация не требуется. Все настройки предопределены в пользовательском интерфейсе и исходном коде.

<div align="center">

**📐 Минимальное разрешение экрана: `1606 × 875`**

</div>

---

## 💡 Примеры

### Создание и заполнение дерева

```csharp
// 🌱 Создание нового дерева
BinaryTree tree = new BinaryTree();

// 🔧 Вставка узлов
tree.Root = tree.Insert(tree.Root, 'A', 10);
tree.Root = tree.Insert(tree.Root, 'B', 5);
tree.Root = tree.Insert(tree.Root, 'C', 15);
tree.Root = tree.Insert(tree.Root, 'D', 3);
tree.Root = tree.Insert(tree.Root, 'E', 12);
```

### Проверка AVL-балансировки

```csharp
// ⚖️ Проверка балансировки
bool isBalanced = tree.IsAVL(tree.Root);

if (isBalanced)
{
    Console.WriteLine("✅ Дерево сбалансировано!");
}
else
{
    Console.WriteLine("❌ Дерево несбалансировано");
}
```

### Визуализация дерева

```csharp
// 🎨 Отрисовка дерева на форме
private void DrawTreeOnForm(Graphics g)
{
    if (tree.Root != null)
    {
        // Параметры: графический контекст, корень, x, y, отступ
        tree.DrawTree(g, tree.Root, 400, 30, 300);
    }
}
```

### Обход дерева

```csharp
// 🔄 Различные виды обхода
tree.InOrderTraversal(tree.Root);    // Симметричный
tree.PreOrderTraversal(tree.Root);   // Прямой
tree.PostOrderTraversal(tree.Root);  // Обратный
```

---

## 🐛 Устранение неполадок

<details>
<summary><strong>🖥️ Проблемы с отображением</strong></summary>

| ❌ Проблема | 🔍 Причина | ✅ Решение |
|-------------|------------|------------|
| Форма отображается некорректно | Низкое разрешение экрана | Установите разрешение ≥ 1606×875 |
| Дерево не отображается | Отсутствуют узлы | Создайте дерево перед визуализацией |
| Графика искажена | Проблемы с масштабированием | Проверьте DPI настройки Windows |

</details>

<details>
<summary><strong>🚀 Проблемы с запуском</strong></summary>

| ❌ Ошибка | 💡 Решение |
|-----------|------------|
| Приложение не запускается | Проверьте зависимости .NET Framework |
| Ошибка точки входа | Убедитесь, что `Program.cs` настроен правильно |
| Исключение при создании формы | Проверьте права доступа к файлам |

</details>

<details>
<summary><strong>🌳 Проблемы с деревьями</strong></summary>

- **Дерево не балансируется**: Проверьте корректность алгоритма вставки
- **Узлы накладываются**: Увеличьте отступы при отрисовке
- **Неверная структура**: Убедитесь в правильности ключей узлов
- **Медленная отрисовка**: Оптимизируйте количество узлов

</details>

---

## 🏗️ Архитектура

### Структура дерева

<div align="center">

```
        Root(A:10)
       /          \
   (B:5)          (C:15)
   /   \          /    \
(D:3) (E:7)   (F:12) (G:18)
```

**Представление AVL-дерева с балансировкой**

</div>

### Основные классы

```csharp
public class TreeNode
{
    public char Symbol { get; set; }     // 🔤 Символьные данные
    public int Key { get; set; }         // 🔑 Ключевое значение
    public TreeNode Left { get; set; }   // ⬅️ Левый потомок
    public TreeNode Right { get; set; }  // ➡️ Правый потомок
    public int Height { get; set; }      // 📏 Высота узла
}
```

### Алгоритмы балансировки

- **🔄 Левый поворот** - для правого перевеса
- **🔄 Правый поворот** - для левого перевеса
- **🔄 Лево-правый поворот** - для сложных случаев
- **🔄 Право-левый поворот** - для сложных случаев

---

<div align="center">
*Сделано с ❤️ для изучения структур данных*
</div>
