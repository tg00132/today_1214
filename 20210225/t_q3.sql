-- 모든 테이블의 데이터를 삭제 
-- DELETE FROM t_user;

-- 테이블 자체를 삭제
-- DROP table t_user;

-- DELETE FROM t_user WHERE i_user = 14;
-- DELETE FROM t_user WHERE user_nm = '이순규';

-- UPDATE t_user SET user_nm = '홍길동' WHERE user_nm = '김순규';

-- SELECT user_nm, user_age, r_dt FROM t_user;
-- select * from = 모든 컬럼의 정보 검색
-- SELECT * FROM t_user;
-- 내림차순 정렬
/*SELECT i_user, user_nm , user_age AS "나이(세)"  FROM t_user WHERE user_age > 20 AND user_age <102
ORDER BY user_age desc;

-- 오름 차순
SELECT i_user, user_nm , user_age AS  "나이(세)" FROM t_user WHERE user_age >= 20 AND user_age <=102
ORDER BY user_age ASC;
*/

/*SELECT  i_user, user_nm, user_age FROM t_user WHERE user_age IN (20,22,100)
ORDER BY i_user;


SELECT  i_user, user_nm, user_age FROM t_user WHERE user_age IN (20,22,100)
ORDER BY user_age DESC, user_nm ASC;

SELECT user_nm AS "성명", user_age AS"나이" FROM t_user WHERE user_age IN (20, 22 ,100) ORDER BY i_user DESC;

SELECT user_nm AS "성명", user_age AS"나이" FROM t_user WHERE user_age BETWEEN  20 AND 100 ORDER BY i_user DESC;

SELECT user_nm AS "성명", user_age AS"나이" FROM t_user WHERE user_age >=20 AND user_age <= 100 i_user DESC;
*/

SELECT user_nm AS "성명", user_age AS"나이" FROM t_user WHERE user_nm LIKE '%동' ORDER BY user_age ASC;

-- mysql  함수;
SELECT SUM(user_age) AS '나이의 총 합계' FROM t_user; 
SELECT MAX(user_age) AS '가장 나이가 많은사람' FROM t_user; 
SELECT avg(user_age) AS '평균나이' FROM t_user; 
SELECT count(user_age) AS '데이터 갯수 ' FROM t_user; 