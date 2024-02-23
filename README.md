# Запрос для получения всех пар «Имя продукта – Имя категории»
```sql
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
```


## Возникшие трудности и принятые решения:

Я не особо понял, как делать запрос к таблицам со связью "многие ко многим" (по крайней мере мне показалось, что именно так они описаны в задании), поэтому я решил добавить промежуточную таблицу, с которой можно удобно работать. Запрос выше сделан для таблиц ниже.

## Таблицы

```sql
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(max)
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(max)
);

CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
```
