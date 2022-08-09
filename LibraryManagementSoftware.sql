CREATE DATABASE LibraryManagementSoftware;
drop DATABASE LibraryManagementSoftware;
USE LibraryManagementSoftware;

CREATE TABLE librarian(
	libId int not null primary key IDENTITY (1, 1),
	libName nvarchar(50),
	libUsername char(30),
	libPassword char(30),
	libEmail char(50),
	libPhone char(10),
);

CREATE TABLE book(
	bookId int not null primary key IDENTITY (1, 1),
	bookName nvarchar(50),
	bookAuthor nvarchar(50),
	bookPublishing date,
	bookAmount int
);

CREATE TABLE reader(
	readerID int not null primary key IDENTITY (1, 1),
	readerName nvarchar(50),
	readerSex nvarchar(20),
	readerBirthday date,
	readerPhone char(10),
	readerAddress nvarchar(50),
	readerCreatedAt date,
	readErexpirationAt date,
);

CREATE TABLE infor(
	bookId int,
	readerId int,
	borrowingDate date,
	returnDate date,
	expirationDate date,
	PRIMARY KEY(bookID, readerId),
	FOREIGN KEY (bookId) REFERENCES book (bookId),
	FOREIGN KEY (readerId) REFERENCES reader (readerId)
);


-- Thêm dữ liệu cho librarian
INSERT INTO librarian VALUES(N'Hoàng Trung Đức', 'duc123', '123', 'duc@gmail.com', '0981421413')
INSERT INTO librarian VALUES(N'Nguyễn Văn Tú', 'tu123', '123', 'tu@gmail.com', '0981421413')


-- thêm dữ liệu cho book
INSERT INTO book VALUES(N'Lập trình winform', N'Đại học Thủy Lợi', '2013-08-25', 100)
INSERT INTO book VALUES(N'Lập trình PHP', N'Đại học Thủy Lợi', '2013-08-25', 100)
INSERT INTO book VALUES(N'Lập trình nodejs', N'Đại học Thủy Lợi', '2013-08-25', 100)
INSERT INTO book VALUES(N'Lập trình c++', N'Đại học Thủy Lợi', '2013-08-25', 100)
INSERT INTO book VALUES(N'Lập trình Java', N'Đại học Thủy Lợi', '2013-08-25', 100)
INSERT INTO book VALUES(N'Lập trình python', N'Đại học Thủy Lợi', '2013-08-25', 100)
INSERT INTO book VALUES(N'Lập trình ?', N'Đại học Thủy Lợi', '2013-08-25', 100)
select * from book



-- Thêm dữ liệu cho đọc giả
INSERT INTO reader VALUES(N'hoàng Trung Đức', N'Nam', '2001-08-25', '0856090453', N'Hồng Tiến - Khoái Châu - Hưng Yên', '2022-08-09',  '2026-08-09')
INSERT INTO reader VALUES(N'Nguyễn Thị Yến', N'Nữ', '2001-08-25', '0856090453', N'Hồng Tiến - Khoái Châu - Hưng Yên', '2022-08-09',  '2026-08-09')
INSERT INTO reader VALUES(N'Lê Thị Bống', N'Nữ', '2001-08-25', '0856090453', N'Hồng Tiến - Khoái Châu - Hưng Yên', '2022-08-09',  '2026-08-09')
INSERT INTO reader VALUES(N'Phạm Văn Quyết', N'Nam', '2001-08-25', '0856090453', N'Hồng Tiến - Khoái Châu - Hưng Yên', '2022-08-09',  '2026-08-09')
INSERT INTO reader VALUES(N'Hoàng Văn An', N'Nam', '2001-08-25', '0856090453', N'Hồng Tiến - Khoái Châu - Hưng Yên', '2022-08-09',  '2026-08-09')
INSERT INTO reader VALUES(N'Nguyễn Thị Lung Linh Lóng Lánh', N'Nam', '2001-08-25', '0856090453', N'Hồng Tiến - Khoái Châu - Hưng Yên', '2022-08-09',  '2026-08-09')
INSERT INTO reader VALUES(N'test', N'Nam', '2001-08-25', '0856090453', N'Hồng Tiến - Khoái Châu - Hưng Yên', '2022-08-09',  '2026-08-09')

-- thêm dữ liệu cho thông tin mượn trả
INSERT INTO infor VALUES( 1 , 1, '2022-07-25', null, '2022-10-25')
INSERT INTO infor VALUES( 1 , 2, '2022-07-25', '2022-08-25', '2022-10-25')
INSERT INTO infor VALUES( 1 , 4, '2022-07-25', null, '2022-10-25')
INSERT INTO infor VALUES( 1 , 4, '2022-07-25', null, '2022-10-25')
INSERT INTO infor VALUES( 6 , 7, '2022-07-25', null, '2022-10-25')
select * from infor

