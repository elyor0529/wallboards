--1
select 
 nvl(count(a.id), 0) count, 
 nvl(sum(a.price), 0) price
 from article a 
 where a.status=0 and 
 (trunc(a.DATEINI)>=to_date('01.01.2011','dd.mm.yyyy')  and trunc(a.date_end)<=to_date('21.07.2017','dd.mm.yyyy'));
 
 --3
 select count(*) count from USER_LIST 
 where TYPE_CLIENT=2 and trunc(ACCREDITATION_DATE)>=to_date('01.01.2011','dd.mm.yyyy');
 
 --4
 select count(*) count from DEALS;
 
 --7
 select * 
 from
 (
     select
     ad.P_PRODUCT_NAME name,count(distinct d.id) count
     from deals d
     join article_details ad on ad.art_id=d.art_id
     where length(ad.P_PRODUCT_NAME)>0
     group by ad.P_PRODUCT_NAME     
     order by count(*) desc
 ) where rownum<4
 order by  1 asc;