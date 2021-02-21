
\connect ClothesstoreDb

CREATE TABLE city (
  city_code varchar(45) NOT NULL,
  name varchar(45) NOT NULL,
  PRIMARY KEY (city_code)
 );

ALTER TABLE "city" OWNER TO clotthesstoreuser;

INSERT INTO city VALUES ('MED','medellin');

CREATE TABLE seller (
  seller_id int NOT NULL,
  name varchar(45) NOT NULL,
  logo varchar(45) DEFAULT NULL,
  PRIMARY KEY (seller_id)
);

ALTER TABLE "seller" OWNER TO clotthesstoreuser;

INSERT INTO seller VALUES (1,'andres','prueba logo');

CREATE TABLE products (
  id  SERIAL PRIMARY KEY,
  name varchar(45) NOT NULL,
  brand varchar(45) DEFAULT NULL,
  thumbnail varchar(45) DEFAULT NULL,
  pictures json DEFAULT NULL,
  descriptio varchar(225) DEFAULT NULL,
  price float NOT NULL,
  discountPrice float DEFAULT NULL,
  discountPercent float DEFAULT NULL,
  currency varchar(45) NOT NULL,
  rating float DEFAULT NULL,
  city_code varchar(45) DEFAULT NULL,
  seller_id int DEFAULT NULL,
  PRIMARY KEY (id),
  KEY city_idx (city_code),
  KEY seller_idx (seller_id),
  KEY city (city_code),
  KEY seller (seller_id),
  KEY city_id (city_code),
  KEY seller_id (seller_id),
  CONSTRAINT city FOREIGN KEY (city_code) REFERENCES city (city_code),
  CONSTRAINT seller FOREIGN KEY (seller_id) REFERENCES seller (seller_id)
)
ALTER TABLE "products" OWNER TO clotthesstoreuser;

INSERT INTO products VALUES ('producto','marca','prueba thumb','{}','description',12.5,12,12,'COP',1.5,'MED',1);




