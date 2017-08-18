-- --------------------------------------------------------
-- 主机:                           127.0.0.1
-- 服务器版本:                        10.2.7-MariaDB - mariadb.org binary distribution
-- 服务器操作系统:                      Win64
-- HeidiSQL 版本:                  9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- 导出 iot 的数据库结构
CREATE DATABASE IF NOT EXISTS `iot` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `iot`;

-- 导出  表 iot.devicebase 结构
CREATE TABLE IF NOT EXISTS `devicebase` (
  `DeviceName` varchar(50) DEFAULT '' COMMENT '设备名称',
  `Model` varchar(50) DEFAULT '' COMMENT '设备型号',
  `Manufactor` varchar(50) DEFAULT '' COMMENT '厂商',
  `Type` varchar(50) DEFAULT '' COMMENT '类型',
  `Description` varchar(50) DEFAULT '' COMMENT '描述',
  `FD` int(20) NOT NULL COMMENT '连接号',
  `LastUpdate` int(20) NOT NULL COMMENT '最后联系时间',
  `MAC` varchar(50) NOT NULL COMMENT 'MAC地址'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 正在导出表  iot.devicebase 的数据：~6 rows (大约)
/*!40000 ALTER TABLE `devicebase` DISABLE KEYS */;
INSERT INTO `devicebase` (`DeviceName`, `Model`, `Manufactor`, `Type`, `Description`, `FD`, `LastUpdate`, `MAC`) VALUES
	('客厅电视', '乐视1A', '乐视', '电视', '陈继坤  啊哈哈哈哈哈哈啊', 4, 1, '28-E3-47-E8-C1-DD'),
	('客厅空调', '格力2B', '格力', '空调', '❀༻(ㆁᴗㆁ❀）我是凉快的小仙女', 1, 2, '28-E3-47-E8-EB-B3'),
	('小火车至尊洗衣机', '强力去污型', '污污污牌', '洗衣机', '宇宙无敌超级霸道全自动智能洗衣洗衣洗衣甩干甩干甩干不可描述机', 3, 3, '08-00-27-00-48-E1'),
	('电磁门', 'NotFound', '404', '门', '使用电磁力实现门锁功能', -1, 6, '08-01-27-00-12-23'),
	('电风扇', '凉快吗', '呼哧牌', '电风扇', '通电线圈在磁场中受力将电能主要转化为机械能并驱动气流的装置', -1, 5, '23-34-A3-20-00-11'),
	('电灯', '小太阳', 'SUN', '灯', '发射可见光频率范围内电磁波与光子的装置', 5, 2, '23-21-65-32-44-54');
/*!40000 ALTER TABLE `devicebase` ENABLE KEYS */;

-- 导出  表 iot.eventbase 结构
CREATE TABLE IF NOT EXISTS `eventbase` (
  `MAC` varchar(50) NOT NULL,
  `EventName` varchar(50) NOT NULL,
  `EventDescription` varchar(50) NOT NULL,
  `EventTime` int(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 正在导出表  iot.eventbase 的数据：~12 rows (大约)
/*!40000 ALTER TABLE `eventbase` DISABLE KEYS */;
INSERT INTO `eventbase` (`MAC`, `EventName`, `EventDescription`, `EventTime`) VALUES
	('28-E3-47-E8-C1-DD', 'ChannelChange', '电视换台，返回的值为频道号', 1501655884),
	('28-E3-47-E8-C1-DD', 'PowerChange', '电源状态改变，0为睡眠 1为开机', 1501682638),
	('28-E3-47-E8-EB-B3', 'PowerChange', '电源状态改变，0为关机 1为开机', 1501652623),
	('28-E3-47-E8-EB-B3', 'TempToHigh', '气温过高，返回值为温度', 1501652623),
	('08-00-27-00-48-E1', 'Wash', '清洗衣服', 1501652623),
	('08-00-27-00-48-E1', 'Dry', '甩干衣服', 1501652623),
	('08-00-27-00-48-E1', 'Dry', '甩干衣服', 1501652623),
	('08-00-27-00-48-E1', 'sth. beyond description', '对洗衣机发起了某些不可描述的行为', 1501652623),
	('08-00-27-00-48-E1', 'Wash', '清洗衣服', 1501652623),
	('28-E3-47-E8-EB-B3', 'TempToLow', '气温过低，返回值为温度', 1501652645),
	('23-21-65-32-44-54', 'SwitchON', '打开电灯', 1501656001),
	('23-21-65-32-44-54', 'SwitchOFF', '关闭电灯', 1501656005);
/*!40000 ALTER TABLE `eventbase` ENABLE KEYS */;

-- 导出  表 iot.funcbase 结构
CREATE TABLE IF NOT EXISTS `funcbase` (
  `MAC` varchar(50) NOT NULL,
  `FunctionName` varchar(50) DEFAULT NULL,
  `FunctionDescrption` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 正在导出表  iot.funcbase 的数据：~6 rows (大约)
/*!40000 ALTER TABLE `funcbase` DISABLE KEYS */;
INSERT INTO `funcbase` (`MAC`, `FunctionName`, `FunctionDescrption`) VALUES
	('28-E3-47-E8-C1-DD', 'ChangeChannel', '换台，参数为台号，HDMI1为-1'),
	('28-E3-47-E8-C1-DD', 'Poweroff', '关机，参数无需填写'),
	('28-E3-47-E8-EB-B3', 'ModeChange', '改变模式，参数为模式号,制冷1 自动2 制暖3 送风4 除湿5'),
	('08-00-27-00-48-E1', 'Wash', '洗衣服'),
	('08-00-27-00-48-E1', 'Dry', '甩干'),
	('08-00-27-00-48-E1', 'sth. beyond description', '对洗衣机进行某些不可描述的动作');
/*!40000 ALTER TABLE `funcbase` ENABLE KEYS */;

-- 导出  表 iot.statusbase 结构
CREATE TABLE IF NOT EXISTS `statusbase` (
  `MAC` varchar(50) NOT NULL,
  `StatusName` varchar(50) NOT NULL,
  `StatusValue` varchar(50) NOT NULL,
  `StatusDescription` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 正在导出表  iot.statusbase 的数据：~3 rows (大约)
/*!40000 ALTER TABLE `statusbase` DISABLE KEYS */;
INSERT INTO `statusbase` (`MAC`, `StatusName`, `StatusValue`, `StatusDescription`) VALUES
	('28-E3-47-E8-C1-DD', 'Channel', '5', '当前频道'),
	('28-E3-47-E8-C1-DD', 'Volume', '25', '当前音量'),
	('28-E3-47-E8-EB-B3', 'Temperature', '26', '当前室温');
/*!40000 ALTER TABLE `statusbase` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
