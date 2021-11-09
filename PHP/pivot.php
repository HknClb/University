<?php
            class quickSort{

                public $arr;
                public function __construct($arr){
                    $this->arr = $arr;
                }
                public function qsort($low,$high){
                    if($low===null || $high===null){    
                        return false;
                    }
                    if($low < $high){           
                        $pi = $this->partition($low,$high);
                        $this->qsort($low,$pi-1);
                        $this->qsort($pi+1,$high);
                    }
                }

                /* Bu fonksiyon son öğeyi pivot olarak alır, 
				pivot öğesini sıralanmış dizideki doğru konumuna yerleştirir ve tüm küçük (pivottan daha küçük) 
				pivotun soluna ve tüm büyük öğeleri pivotun sağına yerleştirir */
                public function partition($low,$high){
                    if($low===null || $high===null){
                        return false;
                    }
                    $pivot = $this->arr[$high];
                    $i = $low-1; /*daha küçük elemanın indeksi*/

                    for($j = $low; $j <= $high-1; $j++)
                    {
                        // Mevcut eleman pivottan küçük veya eşitse

                        if($this->arr[$j] <= $pivot)
                        {
                            $i++;    // daha küçük elemanın artış indeksi
                            $this->swap($i,$j);         
                        }
                    }
                    
                    $this->swap($i+1,$high);

                    return $i+1;    
                }

                public function swap($i,$j){
                    $p=$this->arr[$i];
                    $q=$this->arr[$j];
                    $this->arr[$i]=$q;
                    $this->arr[$j]=$p;      
                }
            }
            $arr = array(75,50,45,85,50,40,70);
            $obj = new quickSort($arr);
            $obj->qsort(0,6);
            print_r($obj->arr);


            ?>