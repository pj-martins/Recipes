﻿# NOTE database naming convention doesn't match ruby standards, since we're reusing it though we'll stick to the MS naming convention
class Measurement < ActiveRecord::Base
	self.table_name = "Measurement"
end