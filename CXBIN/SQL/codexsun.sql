ALTER TABLE `codexsun_db`.`party_tbl`
  CHANGE `STREET1` `STREET_1` VARCHAR (500) CHARSET latin1 COLLATE latin1_swedish_ci NOT NULL,
  CHANGE `STREET2` `STREET_2` VARCHAR (500) CHARSET latin1 COLLATE latin1_swedish_ci NOT NULL;


  ALTER TABLE `codexsun_db`.`invoice_tbl`
  CHANGE `TOTAL_QTY` `TOTAL_QTY` VARCHAR (100) NOT NULL;

  ALTER TABLE `codexsun_db`.`invoiceitems_tbl`
  CHANGE `QTY` `QTY` VARCHAR (100) NOT NULL;

  ALTER TABLE `codexsun_db`.`invoice_tbl`
  AUTO_INCREMENT = 1;

ALTER TABLE `codexsun_db`.`invoiceitems_tbl`
  AUTO_INCREMENT = 1;

