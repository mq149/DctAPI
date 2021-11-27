INSERT INTO "CauHoiTracNghiem" ("NoiDung") VALUES
    ( 'Sơ đồ nào sau đây phù hợp với thiết kế động?' ),
    ( '1+2=?' ),
    ( 'Vai trò nào không có trong ĐI CHỢ THUÊ' ),
    ( 'Trong sơ đồ class, quan hệ aggregration được thể hiện bằng' ),
    ( 'Trong mô hình MVC, View đóng vai trò' );

INSERT INTO "LuaChonTracNghiem" ("NoiDung", "Dung", "CauHoiId") VALUES
    ( 'Class diagram', FALSE, 1 ),
    ( 'Sequence diagram', TRUE, 1 ),
    ( 'Use case diagram', FALSE, 1 ),
    ( 'Package diagram', FALSE, 1 ),
    ( '1', FALSE, 2 ),
    ( '2', FALSE, 2 ),
    ( '3', TRUE, 2 ),
    ( '4', FALSE, 2 ),
    ( 'Shipper', FALSE, 3 ),
    ( 'Khách hàng', FALSE, 3 ),
    ( 'Nhân viên kho', TRUE, 3 ),
    ( 'Cửa hàng', FALSE, 3 ),
    ( 'Mũi tên', FALSE, 4 ),
    ( 'Đường nối', FALSE, 4 ),
    ( 'Hình thoi đen', FALSE, 4 ),
    ( 'Hình thoi trắng', TRUE, 4 ),
    ( 'Gửi request đến và nhận response từ Controller', TRUE, 5 ),
    ( 'Cập nhật giao diện', FALSE, 5 ),
    ( 'Kiểm tra logic dữ liệu', FALSE, 5 ),
    ( 'Lưu trữ dữ liệu vào database', FALSE, 5 );