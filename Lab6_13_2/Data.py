class Data:
    def __init__(self, detail="", quantity=0, distributor=""):
        self.detail = detail
        self.quantity = quantity
        self.distributor = distributor

    def __repr__(self):
        return "{0} {1} {2}".format(self.detail, str(self.quantity), self.distributor)
