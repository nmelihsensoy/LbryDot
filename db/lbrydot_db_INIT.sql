CREATE TABLE "Students" (
	"student_number"	INTEGER NOT NULL UNIQUE,
	"student_email"	TEXT NOT NULL UNIQUE,
	"student_password"	TEXT NOT NULL,
	"student_name"	TEXT NOT NULL,
	"student_avatar"	BLOB,
	PRIMARY KEY("student_number" AUTOINCREMENT)
);

CREATE TABLE "Staff" (
	"staff_id"	INTEGER NOT NULL UNIQUE,
	"staff_email"	TEXT NOT NULL UNIQUE,
	"staff_name"	TEXT NOT NULL,
	"staff_password"	TEXT NOT NULL,
	"staff_type"	INTEGER DEFAULT 1,
	"staff_avatar"	BLOB,
	PRIMARY KEY("staff_id" AUTOINCREMENT)
);

CREATE TABLE "Books" (
	"book_id"	INTEGER NOT NULL UNIQUE,
	"isbn"	TEXT NOT NULL UNIQUE,
	"title"	TEXT NOT NULL,
	"date_of_publication"	TEXT,
	"author"	TEXT,
	"number_of_pages"	INTEGER,
	"category"	TEXT,
	"language"	TEXT,
	"book_cover"	BLOB,
	"shelf_number"	TEXT NOT NULL,
	PRIMARY KEY("book_id" AUTOINCREMENT)
);

CREATE TABLE "Borrowing" (
	"borrow_id"	INTEGER NOT NULL UNIQUE,
	"book_id"	INTEGER NOT NULL,
	"student_number"	INTEGER NOT NULL,
	"issued_date"	TEXT NOT NULL,
	"due_date"	TEXT NOT NULL,
	"returned_date"	TEXT NOT NULL,
	"amount_of_fine"	INTEGER DEFAULT 0,
	PRIMARY KEY("borrow_id" AUTOINCREMENT),
	FOREIGN KEY("student_number") REFERENCES "Students"("student_number") ON DELETE SET NULL,
	FOREIGN KEY("book_id") REFERENCES "Books"("book_id") ON DELETE SET NULL
);

CREATE TABLE "System_Parameters" (
	"id"	INTEGER NOT NULL UNIQUE,
	"daily_fine_amount"	INTEGER NOT NULL DEFAULT 0,
	PRIMARY KEY("id")
);