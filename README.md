# CSharp_Project

## Table of Content
[Cố định vị trí component](codinh)

## <a name="codinh"></a> 	:triangular_flag_on_post: Cố định vị trí component

![image](https://github.com/user-attachments/assets/28353606-52b3-40a0-a95d-11b29c1c0ea0)

Ví dụ với datagridview trên, tìm thuộc tính anchor đang mặc định là `top, left`. Có nghĩa là khoảng cách của datagridview so với bên trên và bên trái được giữ nguyên
,và khoảng cách so với bên dưới và bên phải có thể bị thay đổi dẫn đến tạo khoảng trống.

![image](https://github.com/user-attachments/assets/c5bfe62a-6535-4681-9de6-81fc2e606aed)

Khi chạy chương trình, kích thước form phóng to lên nên datagridview bị cách xa bên dưới và bên phải làm ra khoảng trống.

![Screenshot (101)](https://github.com/user-attachments/assets/27ddb8ce-aea7-4415-b4ff-063060a87a4e)

Bây giờ chỉnh lại cho cố định 4 hướng `top, left, right, bottom` thì datagridview sẽ cố định, không bị dịch chuyển tạo khoảng trống

![image](https://github.com/user-attachments/assets/48850bc8-fb75-443d-bc4e-84f5c5a8cfc5)

***Mục đích là để khi tôi thêm form của các bạn vào form chính thì giao diện các bạn làm không bị xê dịch nhiều. Tùy ý muốn cho component đó cố định như thế nào để set vị trí cho hợp lý***

Ví dụ muốn datagridview bám sát bên dưới có thể chỉnh thành `left, right, bottom` sẽ được như hình dưới

![image](https://github.com/user-attachments/assets/2ee4e174-7e2c-4c7f-a2e8-708e652bd080)


