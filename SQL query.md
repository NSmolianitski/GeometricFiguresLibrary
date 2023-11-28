```sql
   SELECT p.name AS ProductName, c.name AS CategoryName
     FROM Products p
LEFT JOIN Categories c
       ON c.id = p.category_id
```

Судя по заданию, в таблицах продуктов и категорий есть дубликаты, что довольно странно.
Предположу, что в этом случае требуется создать сводную таблицу, которая будет содержать в себе id продукта и категории.
