/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50724
Source Host           : localhost:3306
Source Database       : battery_test_database

Target Server Type    : MYSQL
Target Server Version : 50724
File Encoding         : 65001

Date: 2023-01-06 13:57:22
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for 仪表配置
-- ----------------------------
DROP TABLE IF EXISTS `仪表配置`;
CREATE TABLE `仪表配置` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `仪表名称` varchar(50) NOT NULL,
  `ip` varchar(50) NOT NULL,
  `备注` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of 仪表配置
-- ----------------------------
INSERT INTO `仪表配置` VALUES ('1', '直流电源1', '192.168.123.11', '');
INSERT INTO `仪表配置` VALUES ('2', '直流电源2', '192.168.123.12', '');
INSERT INTO `仪表配置` VALUES ('3', '直流电源3', '192.168.123.13', '');

-- ----------------------------
-- Table structure for 充放电参数
-- ----------------------------
DROP TABLE IF EXISTS `充放电参数`;
CREATE TABLE `充放电参数` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `名称` varchar(50) NOT NULL,
  `电池容量` varchar(50) NOT NULL,
  `充电时间` decimal(10,2) NOT NULL,
  `充电电压` decimal(10,2) NOT NULL,
  `充电电流` decimal(10,2) NOT NULL,
  `充电关断容量` decimal(10,2) NOT NULL,
  `充电关断电压` decimal(10,2) NOT NULL,
  `充电关断电流` decimal(10,2) NOT NULL,
  `放电电压` decimal(10,2) NOT NULL,
  `放电电流` decimal(10,2) NOT NULL,
  `放电时间` decimal(10,2) NOT NULL,
  `放电关断电压` decimal(10,2) NOT NULL,
  `放电关断电流` decimal(10,2) NOT NULL,
  `放电关断容量` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COMMENT='充放电参数';

-- ----------------------------
-- Records of 充放电参数
-- ----------------------------
INSERT INTO `充放电参数` VALUES ('1', '单节锂电池3.7V', '8400mAH', '28800.00', '4.50', '1.00', '0.05', '4.55', '0.05', '2.70', '1.00', '28800.00', '2.65', '0.05', '1.00');
INSERT INTO `充放电参数` VALUES ('2', '多节锂电池12V', '9AH', '28800.00', '12.60', '2.00', '10.00', '12.70', '0.10', '10.80', '1.00', '28800.00', '10.70', '0.10', '10.00');
INSERT INTO `充放电参数` VALUES ('3', '铅酸蓄电池12V', '9AH', '28800.00', '15.00', '2.00', '10.00', '15.10', '0.10', '10.80', '2.00', '28800.00', '10.70', '0.10', '10.00');
