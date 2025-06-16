<?php

use Illuminate\Foundation\Inspiring;
use Illuminate\Support\Facades\Artisan;
use Illuminate\support\Facades\Route;

Artisan::command('inspire', function () {
    $this->comment(Inspiring::quote());
})->purpose('Display an inspiring quote');




Route::get(`/users`,function (){
    return [
        [`id` => 1, `name` => alice],
        [`id` =>2, name => Bob],
    ];

});