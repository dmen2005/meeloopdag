<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

Route::get('/user', function (Request $request) {
    return $request->user();
})->middleware('auth:sanctum');

Route::get('/users', function () {
    return [
        ['id' => 1, 'name' => 'damian'],
        ['id' => 2, 'name' => 'naming=hard'],
    ];
});
