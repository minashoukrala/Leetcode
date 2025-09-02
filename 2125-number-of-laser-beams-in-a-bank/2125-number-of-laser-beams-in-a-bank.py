class Solution:
    def numberOfBeams(self, bank: List[str]) -> int:
        laserInLevel = 0
        laserInLastLevel = 0
        totalLasersBeams = 0
        for s in bank:
            laserInLevel = 0
            for c in s:
                if c == "1":
                    laserInLevel += 1
            print(laserInLastLevel)

            if laserInLevel > 0:
                totalLasersBeams += laserInLastLevel * laserInLevel
                laserInLastLevel = laserInLevel

        return totalLasersBeams
