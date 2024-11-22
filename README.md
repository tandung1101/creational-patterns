# Creational Patterns

Creational Patterns là một nhóm các mẫu thiết kế (Design Patterns) tập trung vào việc khởi tạo đối tượng một cách linh hoạt và hiệu quả. Chúng giúp giảm sự phụ thuộc giữa các lớp, tăng khả năng mở rộng và bảo trì trong hệ thống.

## Các mẫu thiết kế phổ biến trong nhóm Creational Patterns

1. **Factory Method**  
   Cung cấp một giao diện để tạo đối tượng, cho phép các lớp con quyết định loại đối tượng nào sẽ được khởi tạo.  
   - **Khi nào sử dụng:**  
     Khi bạn cần khởi tạo các đối tượng nhưng không muốn mã của bạn bị phụ thuộc vào các lớp cụ thể.
   - **Ví dụ:**  
     Một ứng dụng đặt đồ ăn có thể sử dụng Factory Method để tạo các đối tượng "Pizza" với nhiều loại khác nhau mà không cần chỉnh sửa mã nguồn chính.

2. **Abstract Factory**  
   Cung cấp một giao diện để tạo ra các họ đối tượng liên quan hoặc phụ thuộc lẫn nhau mà không chỉ rõ lớp cụ thể.  
   - **Khi nào sử dụng:**  
     Khi bạn cần làm việc với nhiều họ đối tượng liên quan.

3. **Builder**  
   Cho phép bạn xây dựng các đối tượng phức tạp từng bước.  
   - **Khi nào sử dụng:**  
     Khi cần tạo các đối tượng có cấu trúc phức tạp với nhiều bước khởi tạo.

4. **Prototype**  
   Tạo đối tượng mới bằng cách sao chép một đối tượng hiện có (clone).  
   - **Khi nào sử dụng:**  
     Khi việc khởi tạo đối tượng bằng cách sao chép rẻ hơn so với khởi tạo từ đầu.

5. **Singleton**  
   Đảm bảo rằng chỉ có một thể hiện (instance) của một lớp và cung cấp một điểm truy cập toàn cục đến nó.  
   - **Khi nào sử dụng:**  
     Khi bạn cần một lớp đảm bảo chỉ có một instance trong toàn bộ ứng dụng.

## Tham khảo

- [Refactoring Guru - Factory Method](https://refactoring.guru/design-patterns/factory-method)
