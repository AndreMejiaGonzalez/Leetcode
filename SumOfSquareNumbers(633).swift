class Solution {
    func judgeSquareSum(_ c: Int) -> Bool {
        var a: Double = 0
        let C = Double(c)
        while a * a <= C {
            var b = (C - a * a).squareRoot()
            if floor(b) == b { return true }
            a += 1
        }
        return false
    }
}