INSERT INTO namecard VALUES (0, '가나다','015-112-1234');

-- 4-1
SELECT * FROM namecard;
SELECT * FROM namecard WHERE NAME = '김길동';
SELECT NAME, phone FROM namecard WHERE id = 1;

-- 4-2
SELECT * FROM namecard WHERE id =13;
SELECT * FROM namecard WHERE NAME IS NULL;
SELECT * FROM namecard WHERE NAME LIKE '%길동';
SELECT * FROM namecard WHERE NAME LIKE '_길_';
