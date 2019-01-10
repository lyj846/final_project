function OpenData(x, y) {
    var self = this;
    self.id = 0;
    self.資料集名稱 = "";
    self.主要欄位說明 = "";
    self.服務分類 = "";

    self.Check = function () {
        return !(self.id === 0 ||
            self.資料集名稱 === "" ||
            self.主要欄位說明 === "" ||
            self.服務分類 === "");
    };
}