--1
select
  nvl(count( id), 0) count, 
 nvl(sum(price), 0) price
 from tbloffers
where status=4 and  TO_CHAR(EXPIREDATE, 'YYYY')='2016';

--3

-- 4
 select count(*) count from TBLLOTS
 where STATUS in (2,4,5,6);
 
 --7
  select * 
 from
 (
     select
     pl.NAME name,count(distinct d.id)   count
     from TBLLOTS  d     
     join TBLOFFERS  ad on ad.ID=d.OFFERID
     join TBLPRODUCTS p on ad.PRODUCTID=p.ID
     join TBLPRODUCTTRANSLATES pl on pl.PRODUCTID=p.ID
     where pl.LANGUAGEID=1
     group by pl.NAME
     order by count(*) desc
 ) where rownum<4;