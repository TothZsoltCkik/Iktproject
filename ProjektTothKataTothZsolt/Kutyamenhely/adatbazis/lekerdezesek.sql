-- Válasszuk ki azokat a kutyákat, amelyek barátságosak! (Vigyázz! A tulajdonsagok mező egy string!)
SELECT kutyak.nev, kutyak.tulajdonsagok
FROM menhely
WHERE tulajdonsagok LIKE "%baratsagos%";

-- Válasszuk ki az első 5 legfiatalabb kutyát!
SELECT kutyak.nev, kutyak.kor
FROM menhely
ORDER BY kor LIMIT 5;

-- Jelenítsük meg a kutyákat szobatisztaság szerint!
SELECT kutyak.nev, kutyak.szobatisztaE
FROM menhely
GROUP BY szobatisztaE;

-- Legyenek azok a kutyák szobatiszták, akik 5 évnél fiatalabbak!
UPDATE kutyak
SET szobatisztaE = "Szobatiszta"
WHERE kor < 5;

-- Töröljük azokat a kutyákat, amelyek legalább 16 évesek! (mert nincs elég hely a menhelybe :c)
DELETE FROM kutyak
WHERE kor >= 16;