# 🛒 Ecommerce System – Console Application

This is a simple object-oriented console-based Ecommerce System that simulates basic ecommerce functionalities such as managing products, handling carts, calculating shipping, and processing checkout operations.

## 📦 Features

### 🧾 Product Definition
- Every product has a:
  - Name
  - Price
  - Quantity
- Some products may **expire**, like:
  - Cheese, Biscuits
- Some products may **require shipping**, like:
  - TV, Cheese
- Others may:
  - Not expire (e.g., TV, Mobile)
  - Not require shipping (e.g., Mobile scratch cards)

### 🛒 Cart Management
- Customers can add products to a cart **with a specified quantity**, not exceeding available stock.
- If a product is out of stock or the requested quantity is more than available, an error message is displayed.

### ✅ Checkout Process
During checkout:
- Console prints:
  - 🧾 Order subtotal (sum of all product prices)
  - 🚚 Shipping fees
  - 💰 Paid amount (subtotal + shipping)
  - 🧮 Customer's remaining balance
- ❌ Error messages are shown in these cases:
  - Cart is empty
  - Customer's balance is insufficient
  - One or more products are expired or out of stock

### 📦 Shipping Service
- All shippable products are collected and passed to a ShippingService.
- The service accepts a list of objects implementing an interface:
  - string GetName()
  - double GetWeight()
- Output includes:
  - Product names
  - Quantity
  - Total package weight

---

## 💡 Example Code

csharp
cart.AddProduct("Cheese", 2);
cart.AddProduct("TV", 3);
cart.AddProduct("Scratch Card", 1);
CheckoutService.Process(customer, cart);


### 🖥️ Console Output Example
<img width="800" alt="simple output" src="https://github.com/user-attachments/assets/8badb962-fb77-4bcd-9736-e5c835105305" />
