<?php
class ozellik {
  // Properties
  public $isim;
  public $renk;
  public $marka;

  // Methods
  function set_isim($isim) {
    $this->isim = $isim;
  }
  function get_isim() {
    return $this->isim;
  }
  function set_renk($renk) {
    $this->renk = $renk;
  }
  function get_renk() {
    return $this->renk;
  }
    function set_marka($marka) {
    $this->marka = $marka;
  }
  function get_marka() {
    return $this->marka;
  }
}

class araba extends ozellik
{
    protected function 4teker()
    {
        echo "4 Teker";
    }
}

class motor extends ozellik
{
    protected function 2teker()
    {
        echo "2 Teker";
    }
}
 

$e30 = new ozellik();
$e30->set_isim('E30');
$e30->set_renk('Mavi');
$e30->set_marka('BMW');
echo "isim: " . $e30->get_isim();
echo "<br>";
echo "renk: " . $e30->get_renk();
echo "<br>";
echo "marka: " . $e30->get_marka();
?>