<?php
$veri_seti = [75,50,45,85,50,40,70];

function insertion_sort($veri_seti){
    $sayac = count($veri_seti);
    for($i = 0; $i <= $sayac - 2; $i++){
        $k = $i;
        for($j = $i + 1; $j > 0; $j--){
            if($veri_seti[$j] < $veri_seti[$k]){
                $temp = $veri_seti[$j];
                $veri_seti[$j] = $veri_seti[$k];
                $veri_seti[$k] = $temp;
            }
            if($k > 0 )
                $k--;
        }
    }
    return $veri_seti;
}


echo '<pre>';
print_r(insertion_sort($veri_seti));
echo '</pre>';
    ?>